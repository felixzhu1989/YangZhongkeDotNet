using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Users.Domain;
using Users.Domain.Entities;
using Users.Domain.Events;
using Users.Domain.ValueObject;
using Zack.Infrastructure.EFCore;

namespace Users.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;
        //Redis分布式缓存
        private readonly IDistributedCache _distributedCache;
        private readonly IMediator _mediator;

        public UserRepository(UserDbContext context, IDistributedCache distributedCache, IMediator mediator)
        {
            _context = context;
            _distributedCache = distributedCache;
            _mediator = mediator;
        }
        public Task<User?> FindOneAsync(PhoneNumber phoneNumber)
        {
            return _context.Users.Include(u => u.AccessFail).SingleOrDefaultAsync(ExpressionHelper.MakeEqual((User u) => u.PhoneNumber, phoneNumber));
        }

        public Task<User?> FindOneAsync(Guid id)
        {
            return _context.Users.Include(u => u.AccessFail).SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task AddNewLoginHistoryAsync(PhoneNumber phoneNumber, string msg)
        {
            var user = await FindOneAsync(phoneNumber);
            Guid? userId = null;
            if (user != null) userId = user.Id;
            await _context.UserLoginHistories.AddAsync(new UserLoginHistory(userId, phoneNumber, msg));
            //这里不保存，因为可能不是保存到数据库中，有可能是保存到其他地方
        }

        public Task SavePhoneCodeAsync(PhoneNumber phoneNumber, string code)
        {
            var fullNumber = phoneNumber.RegionCode + phoneNumber.Number;
            var options = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(60)//60秒超时
            };
            //使用Redis分布式缓存，保存验证码
            return _distributedCache.SetStringAsync($"LoginByPhoneCode_Code_{fullNumber}", code, options);
        }
        //获取手机验证码
        public async Task<string?> RetrievePhoneCodeAsync(PhoneNumber phoneNumber)
        {
            var fullNumber = phoneNumber.RegionCode + phoneNumber.Number;
            var cacheKey = $"LoginByPhoneCode_Code_{fullNumber}";
            var code = await _distributedCache.GetStringAsync(cacheKey);
            //验证码只用一次，用完以后就删除
            await _distributedCache.RemoveAsync(cacheKey);
            return await Task.FromResult(code);
        }
        //发布事件
        public Task PublishEventAsync(UserAccessResultEvent eventData)
        {
            return _mediator.Publish(eventData);
        }
    }
}
