using product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water
{
    public class Water : Product
    {
        //ATTRIBUTO
        private float capacity;
        private float liters;
        private float ph;
        private string source;


        //COSTRUTTORE
        public Water(float price, string name = "", string description = "", string categoryName = "",float liters = 0, float ph = 0, string source = "") : base(price, name, description, categoryName)
        {
            this.capacity = liters;
            this.liters = liters;
            this.ph = ph;
            this.source = source;
        }

        //PROPERTIES
        public float Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }
        public float Liters
        {
            get
            {
                return this.liters;
            }
            set
            {
                this.liters = value;
            }
        }

        public float Ph
        {
            get
            {
                return this.ph;
            }
            set
            {
                this.ph = value;
            }
        }

        public string Source
        {
            get
            {
                return this.source;
            }
            set
            {
                this.source = value;
            }
        }

        //METODI
        public string Drink(float litersToDrink)
        {
            if (litersToDrink < liters)
            {
                this.liters -= litersToDrink;
                return "The water is over";
            } else 
            {
                return "You have not enough water";
            }
        }

        public void FillBottle()
        {
            this.liters = this.capacity;
        }

        public void EmptyBottle()
        {
            this.liters = 0;
        }

        public override string ProductRappresentationString()
        {
            string productRappresentation =
            "-----------------------------------------------\n" +
            $"Product code: {this.Code}\n" +
            $"Product name: {this.Name}\n" +
            $"Product description: {this.Description}\n" +
            $"Product category: {this.Category.CategoryRappresentationString()}\n" +
            $"Bottle size: {this.Liters}\n" +
            $"Water ph: {this.Ph}\n" +
            $"Water source: {this.Source}\n" +
            $"Product price: {this.Price}\n" +
            $"Taxes: {this.Taxation}\n" +
            "-----------------------------------------------";

            return productRappresentation;
        }
    }
}
