using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Fishazon.Models
{
    public class Item
    {
        [Key]
        public int ItemId {get;set;}
        public int OrderId {get;set;}
        public string ItemName {get;set;}
        public int Amount {get;set;} = 1;
        public double Price {get;set;}
        public string Img {get;set;}
        public Order Order {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }  
}
