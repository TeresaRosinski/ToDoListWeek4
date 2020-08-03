using System; 

namespace ToDoList.Models
{
  public class CategoryItem
  {
    //3 id properties
    public int CategoryItemId {get; set;}
    public int ItemId {get; set; }
    public int CategoryId {get; set; }
    public Item Item {get; set;}
    public Category Category {get; set;}
 
  }
}