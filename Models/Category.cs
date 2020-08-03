using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Category
    {
        public Category()
        { // Collection Navigation Property
            this.Items = new HashSet<Item>();
        }

        public int CategoryId { get; set; } //auto-implemented
        public string Name { get; set; } // auto-implemented
        public virtual ICollection<Item> Items { get; set; }
    }
}