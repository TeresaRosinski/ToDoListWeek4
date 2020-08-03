using System.Collections.Generic; 
namespace ToDoList.Models
{
  public class Item
  {
    public Item()
        { //collection navigation property for categories
            this.Categories = new HashSet<CategoryItem>();
        }
    public int ItemId { get; set; }
    public string Description { get; set; }
    public ICollection<CategoryItem> Categories { get;} // only has a getter
    
  }
}