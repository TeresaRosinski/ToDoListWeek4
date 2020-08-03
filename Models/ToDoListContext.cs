using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    //each dbset will become a table in our database
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<CategoryItem> CategoryItem {get; set; } // our new joined table
    
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}