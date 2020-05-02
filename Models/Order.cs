using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Fishazon.Models
{
    public class Order
    {
        [Key]
        public int OrderId {get;set;}
        public int UserId {get;set;}
        public bool Complete {get;set;} = false;
        public List<Item> CreatedItems {get;set;}
        public User Creator {get;set;}
        public Order() {
            CreatedItems = new List<Item>();
        }
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }  
}
   