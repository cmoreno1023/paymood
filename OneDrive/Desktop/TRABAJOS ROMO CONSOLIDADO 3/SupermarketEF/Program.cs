// See https://aka.ms/new-console-template for more information
using SupermarketEF.Data;
using SupermarketEF.Models;

Console.WriteLine("Hello, World!");
static void Main(string[] args)
{
    using SumermarketContext context = new SumermarketContext();
    // Se crea el objeto oilCategory de tipo Category
    Category oilCategory = new Category()
    {
        Name = "Oil",
        description = "Oil Category"
    };
    // Se agrega el objeto creado al contexto de la BD
    // Usando la propieda Categories del contexto
    context.Categories.Add(oilCategory);
    // Se crea el objeto grainsCategory de tipo Category
    // Se agrega el objeto creado al contexto de la BD
    var grainsCategory = context.Categories
         .Where(p => p.Name == "Grains")
        .FirstOrDefault();
    if (grainsCategory is Category)
    {
        grainsCategory.description = "New desciption applied";
        context.Remove(grainsCategory);
    }
    // Se graban los cambios realizados al contexto
    context.SaveChanges();
    // Recupera todas las categorias y las ordena por el nombre
    var categories = context.Categories.OrderBy(p => p.Name);
    foreach (var category in categories)
    {
        Console.WriteLine($"{category.Name} | {category.description}");
    }
}