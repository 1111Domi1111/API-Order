using System;
using System.Collections.Generic;


namespace WebApplication1
{
    public class Order
    {
        public string name { get; set; }

        public int id { get; set; }
        public List<Dishes> ValueDishes { get; set; }
        public List<Drinks> ValueDrinks { get; set; }


    }
}
