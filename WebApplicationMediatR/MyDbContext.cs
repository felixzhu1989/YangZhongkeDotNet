using MediatR;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationMediatR
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        //注入IMediator服务
        private readonly IMediator _mediator;
        //将配置SQL Server的代码转移到program中
        public MyDbContext(DbContextOptions<MyDbContext> options, IMediator mediator) : base(options)
        {
            _mediator = mediator;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //在program中配置SQL Server
            //var connStr = @"Server=PDMSERVER\SQLEXPRESS; Database=EFCoreTestDB; User Id = sa; Password=Epdm2018;TrustServerCertificate=true;MultipleActiveResultSets=true";
            //optionsBuilder.UseSqlServer(connStr);
            //打开日志记录
            optionsBuilder.LogTo(Console.WriteLine);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //this.GetType().Assembly在当前类所在的程序集中解析所有实现了IEntityTypeConfiguration接口类
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
        }

        //重写SaveChangesAsync，来发布注册过的事件，达到事件延迟发布的需求
        public  override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            //先获得所有被跟踪的实体,这些实体必须实现了IDomainEvents
            //即获取所有含有未发布事件的实体对象
            var domainEntities = ChangeTracker.Entries<IDomainEvents>()
                .Where(e=>e.Entity.GetDomainEvents().Any());
            //获取所有待发布的消息,ToList()防止延迟加载，先记录下所有的待发布消息
            var domainEvents = domainEntities.SelectMany(x => x.Entity.GetDomainEvents()).ToList();
            //遍历domainEntities，清空其中的对象
            domainEntities.ToList().ForEach(e=>e.Entity.ClearDomainEvent());
            //遍历所有注册过的消息
            foreach (var domainEvent in domainEvents)
            {
                //发布消息
                await _mediator.Publish(domainEvent, cancellationToken);
            }
            //把消息的发布放在SaveChangesAsync之前，
            //保证领域事件响应代码中的事务操作和SaveChangesAsync的代码在同一个事务中
            //实现强一致性事务
            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
