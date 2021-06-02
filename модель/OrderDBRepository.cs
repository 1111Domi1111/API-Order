using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public class OrderDBRepository
    {
        public Item Item { get; set; }
    }
    public class Item
    {
        public Id Id { get; set; }
        public DishesOrCoctails DishesOrCoctails { get; set; }
        public Pay Pay { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
    public class Id
    {
        public string S { get; set; }
    }
    public class OrderStatus
    {
        public string S { get; set; }
    }
    public class Pay
    {
        public string S { get; set; }
    }
    public class DishesOrCoctails
    {
        public List<string> SS { get; set; }
    }
    
    

}