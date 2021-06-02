using System;
using System.Collections.Generic;

namespace WebApplication1
{
    public class ListDish
    {
        public List<Dishes> Results { get; set; }
    }
    public class Dishes
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

    }
}