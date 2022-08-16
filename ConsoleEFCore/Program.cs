using ConsoleEFCore;
using Microsoft.EntityFrameworkCore;


await using TestDbContext context = new TestDbContext();

//插入数据
/*
Person p = new Person
{
    Name = "felix",
    Age = 18
};
await context.Persons.AddAsync(p);
await context.SaveChangesAsync();
*/
/*
Book book1 = new Book{AuthorName = "yzk",Title = "零基础学习C#",Price = 3,PubTime = new DateTime(2019,3,15)};
Book book2 = new Book {AuthorName = "robbort",Title = "算法",Price = 10,PubTime = new DateTime(2012,5,5)};
Book book3 = new Book{AuthorName = "wu",Title = "sql",Price =2,PubTime = new DateTime(2008,2,9)};
Book book4 = new Book{AuthorName = "zhf",Title = "hello",Price =1,PubTime = new DateTime(2020,8,5)};
await context.AddRangeAsync(book1, book2, book3, book4 );
await context.SaveChangesAsync();
*/

//查询数据

var books = context.Books.Where(b => b.Price > 2);
foreach (var book in books)
{
    Console.WriteLine(book.Title);
}
var sqlStr= books.ToQueryString();
Console.WriteLine(sqlStr);

/*
var groups = context.Books.GroupBy(b => b.AuthorName).Select(g => new {AuthorName = g.Key,BooksCount=g.Count(),MaxPrice=g.Max(b=>b.Price)});
foreach (var g in groups)
{
    Console.WriteLine($"作者：{g.AuthorName}，著作数：{g.BooksCount}，最贵价格：{g.MaxPrice}");
}
*/
/*
var book=context.Books.Single(b=>b.Title=="sql");
book.AuthorName = "Jun Wu";
*/
/*
var book =context.Books.Single(b=>b.Title=="hello");
context.Remove(book);//也可携程context.Books.Remove(book);
*/
//给大于1块的书都涨1块
/*
var books = context.Books.Where(b => b.Price > 1);
foreach (var book in books)
{
    book.Price += 1;
}
*/
/*
await context.BatchUpdate<Book>()
    .Set(b => b.Price, b => b.Price + 1)
    .Where(b => b.Price > 1).ExecuteAsync();
await context.SaveChangesAsync();
*/


