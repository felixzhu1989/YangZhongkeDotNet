// See https://aka.ms/new-console-template for more information
using ConsoleAppLinq;

Console.WriteLine("Hello, World!");
List<Employee> list = new List<Employee>
{
    new() {Id = 1, Name = "jerry", Age = 28, Gender = true, Salary = 5000},
    new() {Id = 2, Name = "jim", Age = 33, Gender = true, Salary = 3000},
    new() { Id=3, Name="lily", Age=35, Gender=false, Salary=3000 },
    new() { Id=4, Name="lucy", Age=16, Gender=false, Salary=1000 },
    new() { Id=5, Name="kimi", Age=28, Gender=true, Salary=8000 },
    new() { Id=6, Name="felix", Age=28, Gender=false, Salary=2000 },
    new() { Id=7, Name="zack", Age=35, Gender=true, Salary=1000 },
    new() { Id=8, Name="jack", Age=33, Gender=true, Salary=8000 }
};
//Where
var resultWhere = list.Where(e => e.Age > 30);
foreach (var e in resultWhere)
{
    Console.WriteLine(e);
}
//Count
var resultCount = list.Count(e => e.Age>30);
Console.WriteLine(resultCount);
//Any
var resultAny=list.Any(e => e.Age>30);
Console.WriteLine(resultAny);

//Single
//var resultSingle=list.Single(e => e.Age>30);
//错误异常：System.InvalidOperationException:“Sequence contains more than one matching element”
var resultSingle = list.Single(e => e.Name=="jerry");
Console.WriteLine(resultSingle);
var resultSingleOrDefault = list.SingleOrDefault(e => e.Name=="dd");
Console.WriteLine(resultSingleOrDefault==null);

//First
//var resultFirst = list.First(e => e.Age>40);
//错误异常：System.InvalidOperationException:“Sequence contains no matching element”
var resultFirstOrDefault = list.FirstOrDefault(e => e.Age>40);
Console.WriteLine(resultFirstOrDefault == null);

//Order
var resultOrder=list.OrderBy(e => e.Age);
foreach (var e in resultOrder)
{
    Console.WriteLine(e);
}
var resultOrderByDesc=list.OrderByDescending(e => e.Age);
foreach (var e in resultOrderByDesc)
{
    Console.WriteLine(e);
}
//随机排序
var resultGuid = list.OrderBy(e => Guid.NewGuid());
foreach (var e in resultGuid)
{
    Console.WriteLine(e);
}
Random rand = new Random();
var resultRand = list.OrderBy(e => rand.Next());
foreach (var e in resultRand)
{
    Console.WriteLine(e);
}
//按照名字的最后一个字符排序
var resultOrderByLast=list.OrderBy(e => e.Name[^1]);//[e.Name.Length-1]
foreach (var e in resultOrderByLast)
{
    Console.WriteLine(e);
}
//多规则排序,案例：优先按照Age排序，如果Age相同再按照Salary排序
var resultMultiOrder=list.OrderBy(e => e.Age).ThenByDescending(e=>e.Salary);
foreach (var e in resultMultiOrder)
{
    Console.WriteLine(e);
}

//Skip,Take
//案例：从第2条开始获取3条数据
var resultSkipTake =list.Skip(2).Take(3);
foreach (var e in resultSkipTake)
{
    Console.WriteLine(e);
}

//聚合函数，链式编程
var resultMin = list.Where(e => e.Age > 30).Min(e=>e.Salary);
Console.WriteLine(resultMin);
var resultMax = list.Where(e => e.Age > 30).Max(e => e.Salary);
Console.WriteLine(resultMax);
var resultAverage = list.Where(e => e.Age > 30).Average(e => e.Salary);
Console.WriteLine(resultAverage);
//GroupBy
var resultGroupBy=list.GroupBy(e => e.Age).OrderBy(g=>g.Key);
foreach (var g in resultGroupBy)
{
    Console.WriteLine(g.Key);
    Console.WriteLine($"最高工资{g.Max(e=>e.Salary)}");
    foreach (var e in g)
    {
        Console.WriteLine(e);
    }
    Console.WriteLine("--------");
}

//Select
//投影，把集合中的每一项转换为另外一种类型
//将Employee类型对象逐个转换为int（只取出年龄）
var ages =list.Select(e=>e.Age);
//将Employee类型对象逐个转换为string（只取出性别）
var names =list.Select(e=>e.Gender?"男":"女");
//将Employee类型对象逐个转换为Dog类型（取出多个属性）
var dogs =list.Select(e=>new Dog{NickName=e.Name,Age=e.Age});
foreach (var d in dogs)
{
    Console.WriteLine(d);
}

//AnonymousType匿名类型
var p = new {Name = "Tom", Id = 1};
var obj1 = new {Name="jerry", Id = 1, Age=30};
//投影与匿名类,var的高光时刻
var resultT =list.Select(e=>new{e.Name,e.Age,e.Salary});
foreach (var t in resultT)
{
    Console.WriteLine($"Name={t.Name},Age={t.Age},Salary={t.Salary}");
}

//综合运用

var resultAll =list.GroupBy(e=>e.Age).OrderBy(g => g.Key).Select(g=>new{AgeGroup=g.Key,MasSalary=g.Max(e=>e.Salary),MinSalary=g.Min(e=>e.Salary),Count=g.Count()});
foreach (var a in resultAll)
{
    Console.WriteLine($"AgeGroup={a.AgeGroup},MasSalary={a.MasSalary},MinSalary={a.MinSalary},Count={a.Count}");
}


//集合转换
IEnumerable<Employee> employees = list.Where(e => e.Salary > 6000);
List<Employee> employeeList = employees.ToList();
Employee[] employeeArray= employees.ToArray();

//链式调用
//获得Id>2的数据，然后按照Age分组，并且把分组按照Age排序，然后取出前三条数据，最后再投影，取得年龄，人数，平均工资。
var chainResult = list.Where(e => e.Id > 2).GroupBy(e => e.Age).OrderBy(g => g.Key).Take(3).Select(g => new { AgeGroup = g.Key,Count=g.Count(), AverageSalary = g.Average(e=>e.Salary)});
foreach (var a in chainResult)
{
    Console.WriteLine($"AgeGroup={a.AgeGroup},Count={a.Count},AverageSalary={a.AverageSalary}");
}

string strScore = "61,90,100,99,18,22,38,66,80,93,55,50,89";
//var scores = strScore.Split(",");
//List<int> nums=new List<int>();
//foreach (var s in scores)
//{
//    nums.Add(Convert.ToInt32(s));
//}
//var resultAvg=nums.Average(n=>n);
var resultAvg = strScore.Split(",").Select(s => Convert.ToInt32(s)).Average();
Console.WriteLine($"Average Score:{resultAvg}");

string strTemp = "ssw,Szsd wDjqw,WlkjaoWjSdk,RpqH elhj";
//var resultTemp= strTemp.Select(s => s).GroupBy(s => s).OrderBy(g => g.Key).Where(g=>g.Count()>2).Select(g => new {Letter=g.Key,Count = g.Count()});
var resultTemp = strTemp.Where(char.IsLetter).Select(char.ToLower).GroupBy(c=>c).Select(g => new { Letter = g.Key, Count = g.Count() }).OrderByDescending(g=>g.Count).Where(g=>g.Count>2);
foreach (var g in resultTemp)
{
    Console.WriteLine($"Letter:{g.Letter},Frequency:{g.Count}");
}
    
Console.Read();