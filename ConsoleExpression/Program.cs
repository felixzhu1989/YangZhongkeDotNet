using System.Linq.Expressions;
using ConsoleExpression;
using ExpressionTreeToString;
using Microsoft.EntityFrameworkCore;
using static System.Linq.Expressions.Expression;
using System.Linq.Dynamic.Core;

await using MyDbContext context = new MyDbContext();

/*//左边是表达式树的类型，右边是表达式树的表达式
//查找书的价格大于5的书
Expression<Func<Book, bool>> e1 = b => b.Price > 5;
Console.WriteLine(e1.ToString("Object notation","C#"));*/


/*//将两本书的价格加在一起
Expression<Func<Book, Book,double>> e2=(b1,b2)=>b1.Price+b2.Price;
Console.WriteLine(e2.ToString("Object notation", "C#"));*/

/*//委托
Func<Book, bool> f1 = b => b.Price > 5;
await context.Books.Where(e1).ToArrayAsync();*/


/*//动态构建表达式树
ParameterExpression paramExprB = Expression.Parameter(typeof(Book),"b");
MemberExpression menExprPrice = Expression.MakeMemberAccess(paramExprB, typeof(Book).GetProperty("Price")!);
ConstantExpression constExpr5=Expression.Constant(5d,typeof(double));
BinaryExpression binExprGreaterThan=Expression.GreaterThan(menExprPrice,constExpr5);
Expression<Func<Book, bool>> exprRoot = Expression.Lambda<Func<Book,bool>>(binExprGreaterThan,paramExprB);
await context.Books.Where(exprRoot).ToArrayAsync();*/

/*//让用户输入条件，动态构建表达式树
Console.WriteLine("请选择筛选方式，1大于，2小于");
string s = Console.ReadLine()!;
ParameterExpression paramExprB = Expression.Parameter(typeof(Book), "b");
MemberExpression menExprPrice = Expression.MakeMemberAccess(paramExprB, typeof(Book).GetProperty("Price")!);
ConstantExpression constExpr5 = Expression.Constant(5d, typeof(double));
BinaryExpression binExprCompare = s=="1" ? 
    Expression.GreaterThan(menExprPrice, constExpr5) : 
    Expression.LessThan(menExprPrice, constExpr5);
Expression<Func<Book, bool>> exprRoot = Expression.Lambda<Func<Book, bool>>(binExprCompare, paramExprB);
await context.Books.Where(exprRoot).ToArrayAsync();*/

/*//简化动态构建表达式树
Expression<Func<Book, bool>> e1 = b => b.Price > 5;
Console.WriteLine(e1.ToString("Factory methods", "C#"));*/


/*// using static System.Linq.Expressions.Expression;
var b = Parameter(
    typeof(Book),
    "b"
);
//规定接收表达式返回值类型为<Func<Book, bool>>
var expr = Lambda<Func<Book, bool>>(
    GreaterThan(
        MakeMemberAccess(b,
            typeof(Book).GetProperty("Price")!
        ),
        Constant(5d)//调整数据类型为double
    ),
    b
);
await context.Books.Where(expr).ToArrayAsync();*/


/*//让用户输入条件，动态构建表达式树
Console.WriteLine("请选择筛选方式，1大于，2小于");
string s = Console.ReadLine()!;
var b = Parameter(typeof(Book), "b");
var exprPrice = MakeMemberAccess(b, typeof(Book).GetProperty("Price")!);
var exprCompare = s == "1"
    ? GreaterThan(exprPrice, Constant(5d))
    : LessThan(exprPrice, Constant(5d));
//规定接收表达式返回值类型为<Func<Book, bool>>
var expr = Lambda<Func<Book, bool>>(exprCompare, b);
await context.Books.Where(expr).ToArrayAsync();*/

/*//先观察静态表达式树是什么样，再来根据逻辑构建动态表达式树。
Expression<Func<Book, bool>> e1 = b => b.Price == 5;
Console.WriteLine(e1.ToString("Factory methods", "C#"));

Expression<Func<Book, bool>> e2 = b => b.AuthorName == "yzk";
Console.WriteLine(e2.ToString("Factory methods", "C#"));*/

/*var books = QueryBooks("AuthorName","yzk");
foreach (var book in books)
{
    Console.WriteLine($"For AuthorName-----Id:{book.Id},Title:{book.Title}");
}

var books2 = QueryBooks("Price", 4);
foreach (var book in books2)
{
    Console.WriteLine($"For Price-----Id:{book.Id},Title:{book.Title}");
}

IEnumerable<Book> QueryBooks(string propertyName, object value)
{
    var b = Parameter(typeof(Book), "b");
    var valueType = typeof(Book).GetProperty(propertyName)!.PropertyType;
    var memberExpr = MakeMemberAccess(b, typeof(Book).GetProperty(propertyName)!);
    var constExpr = Constant(System.Convert.ChangeType(value, valueType));
    //注意将输入的int类型转换为double类型,IsPrimitive判断数据是否为基本数据类型
    var bodyExpr = valueType.IsPrimitive ? 
        Equal(memberExpr, constExpr) :
        MakeBinary(ExpressionType.Equal, memberExpr,
            constExpr, false, typeof(string).GetMethod("op_Equality"));

    var expr = Lambda<Func<Book, bool>>(bodyExpr, b);
    return context.Books.Where(expr);
}*/

/*//只查询部分属性
//静态查询部分属性
var books=context.Books.Select(b => new {b.Id, b.Title});
foreach (var book in books) 
{
    Console.WriteLine($"{book.Id},{book.Title}");
}*/
/*//动态查询部分属性,构建一个动态的object数组作为查询结果
var books = context.Books.Select(b => new object[] {b.Id, b.Title});
foreach (var book in books)
{
    Console.WriteLine($"{book[0]},{book[1]}");
}*/


/*//实现Select的动态化
//动态指定需要查询的属性
var items=QueryDynamic<Book>("Id","Title");
foreach (var item in items)
{
    Console.WriteLine($"{item[0]},{item[1]}");
}

IEnumerable<object[]> QueryDynamic<T>(params string[] propertyNames) where T:class
{
    var p = Parameter(typeof(T));
    List<Expression> propExprList=new List<Expression>();
    foreach (var propName in propertyNames)
    {
        var propExpr = Convert(MakeMemberAccess(p, typeof(T).GetProperty(propName)!),typeof(object));
        propExprList.Add(propExpr);
    }
    var newArrayExpr = NewArrayInit(typeof(object), propExprList.ToArray());
    var selectExpr = Lambda<Func<T, Object[]>>(newArrayExpr, p);
    return context.Set<T>().Select(selectExpr).ToArray();
}*/


/*//IQueryable实现动态表达式树相同的效果
var q1 = context.Books.Where(b => b.Price > 2);
q1 = q1.Where(b => b.AuthorName == "yzk");//延迟加载，可将多个查询条件拼接到一起执行
foreach (var book in q1)
{
    Console.WriteLine(book.Title);
}*/

/*//IQueryable实现动态条件查询案例
var items = QueryDynamic(null,1,10,1);
foreach (var item in items)
{
    Console.WriteLine(item.Title);
}

IEnumerable<Book> QueryDynamic(string? title,double? lowerPrice,double? upperPrice,int orderByType)
{
    IQueryable<Book> books=context.Books;
    if (title != null) books = books.Where(b => b.Title.Contains(title));
    if (lowerPrice != null) books = books.Where(b => b.Price>=lowerPrice);
    if (upperPrice != null) books = books.Where(b => b.Price<=upperPrice);
    if (upperPrice != null) books = books.Where(b => b.Price<=upperPrice);
    switch (orderByType)
    {
        case 1:
            books = books.OrderByDescending(b => b.Price);
            break;
        case 2:
            books = books.OrderBy(b => b.Price);
            break;
        case 3:
            books = books.OrderByDescending(b => b.PubTime);
            break;
        case 4:
            books = books.OrderBy(b => b.PubTime);
            break;
        default:
            break;
    }
    return books.ToArray();
}*/

//System.Linq.Dynamic.Core
double price = 5;
context.Books.Where($"Price>={price} and Price<=6").Select("new(Title,Price)").ToDynamicArray();
