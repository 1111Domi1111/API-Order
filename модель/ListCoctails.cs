using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class ListCoctails
    {
        public List< Drinks> Drinks { get; set; }
    }
    public class Drinks
    {

        [Key]
        public string IdDrink { get; set; }
        public string StrDrink { get; set; }
        public string StrCategory { get; set; }

    }
    }