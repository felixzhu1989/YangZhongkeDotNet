using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationWebApi.Controllers
{
    // [Route("api/[controller]")] //REST风格
    [Route("api/[controller]/[action]")] //RPC风格
    [ApiController]
    public class PersonsController : ControllerBase
    {
        //REST风格
        //[HttpGet] //方法叫什么无所谓
        //public IEnumerable<Person> GetPersons(){}
        //[HttpGet("{id}")]
        //public Person GetPerson(long id){}
        //[HttpPut("{id}")]
        //public void UpdatePerson(long id, Person person){}
        //[HttpPost]
        //public void SavePerson(Person person){}
        //[HttpDelete("{id}")]
        //public void DeletePerson(long id){}

        //RPC风格
        [HttpGet]
        public Person[] GetAll()
        {
            return new Person[] {new Person(1,"yzk", true, DateTime.Now), new Person(2,"zhf", true, DateTime.Now)};
        }

        [HttpGet]
        public Person? GetById(long id)
        {
            if (id == 1) return new Person(1, "Tom", false, DateTime.Now);
            else if (id == 2) return new Person(2, "Jerry", false, DateTime.Now);
            else return null;
        }

        [HttpPost]
        public string AddNew(Person p)
        {
            return "搞定";
        }
    }
}
