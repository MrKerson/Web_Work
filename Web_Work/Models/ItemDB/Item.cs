using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Work.Models.ItemDB
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }
        public double Weight { get; set; }
        public string Time { get; set; }
    }
}