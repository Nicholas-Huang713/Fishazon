using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Fishazon.Models
{
    public class Product
    {
        [Key] 
        public int ProductId {get;set;}
        public string Category {get;set;}
        public string Name {get;set;}
        public double Price {get;set;}
        public string Img {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }  
}