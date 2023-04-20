using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using product;

namespace cannedfood
{
    public class CannedFood : Product
    {
        //ATTRIBUTI
        private int expiringYear;
        private float capacity;
        private float weight;

        //COSTRUTTORE
        public CannedFood(float price, string name = "", string description = "", string categoryName = "" ,int expiringYear = 2023, float capacity = 0, float weight = 0) : base(price, name, description, categoryName) 
        { 
            this.expiringYear = expiringYear;
            this.capacity = capacity;
            this.weight = weight;
        }

        //PROPRIETÀ
        public int ExpiringYear
        {
            get
            {
                return this.expiringYear;
            }
            set
            {
                this.expiringYear = value;
            }
        }

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

        public float Weight
        {
            get
            {
                return this.weight;
            }
            set
            {
                this.weight = value;
            }
        }

        //METODI
        public string Eat(int currentYear)
        {
            if (currentYear < this.expiringYear)
            {
                this.weight = 0;
                return "The food is over";
            } else
            {
                return "The food is expired";
            }
        }

        public override string ProductRappresentationString()
        {
            string productRappresentation =
            "-----------------------------------------------\n" +
            $"Product code: {this.Code}\n" +
            $"Product name: {this.Name}\n" +
            $"Product description: {this.Description}\n" +
            $"Product category: {this.Category.CategoryRappresentationString()}\n" +
            $"Can size: {this.Capacity}\n" +
            $"Expiring date: {this.ExpiringYear}\n" +
            $"Product price: {this.Price}\n" +
            $"Taxes: {this.Taxation}\n" +
            "-----------------------------------------------";

            return productRappresentation;
        }
    }
}
