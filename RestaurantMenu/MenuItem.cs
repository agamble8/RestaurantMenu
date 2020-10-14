using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantMenu
{
    class MenuItem
    {
        //private string name;
        private float price;
        private string description;
        private string category;
        private DateTime itemAdded;

        public float Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime ItemAdded { get; }
        public MenuItem(float price, string description, string category, DateTime itemAdded)
        {
            this.price = price;
            this.description = description;
            this.category = category;
            this.itemAdded = itemAdded;
        }
    }
}
