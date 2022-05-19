using EfCoreTest;


Console.WriteLine("EF Query Test");
Console.WriteLine("-----------------------------------");

var factory = new DbContextFactory();
using var context = factory.CreateDbContext(args);

var test = context.Dishes.ToList();






