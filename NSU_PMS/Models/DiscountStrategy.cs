using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSU_PMS.Models
{
    public class DiscountStrategy
    {
        public interface IDiscount
        {
            double ApplyDiscount(double price);
        }

        public class NoDiscount : IDiscount
        {
            public double ApplyDiscount(double price)
            {
                return price;
            }
        }

        public abstract class DiscountDecorator : IDiscount
        {
            protected IDiscount _innerDiscount;

            public DiscountDecorator(IDiscount innerDiscount)
            {
                _innerDiscount = innerDiscount;
            }

            public virtual double ApplyDiscount(double price)
            {
                return _innerDiscount.ApplyDiscount(price);
            }
        }
        public class PercentageDiscountDecorator : DiscountDecorator
        {
            private readonly double _discountPercentage;

            public PercentageDiscountDecorator(IDiscount innerDiscount, double discountPercentage)
                : base(innerDiscount)
            {
                _discountPercentage = discountPercentage;
            }

            public override double ApplyDiscount(double price)
            {
                double discountedPrice = base.ApplyDiscount(price);
                return discountedPrice - (discountedPrice * _discountPercentage / 100);
            }
        }

        public class ClientDiscountDecorator : DiscountDecorator
        {
            private readonly double _discountAmount;

            public ClientDiscountDecorator(IDiscount innerDiscount, double discountAmount)
                : base(innerDiscount)
            {
                _discountAmount = discountAmount;
            }

            public override double ApplyDiscount(double price)
            {
                double discountedPrice = base.ApplyDiscount(price);
                return discountedPrice - (discountedPrice * _discountAmount / 100);
            }
        }

        public class Product
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Category { get; set; }
            public int BoxContent { get; set; }
            public int StripSize { get; set; }
            public double Discount { get; set; }
            public int Quantity { get; set; }
            public double Price { get; set; }
            public double TotalValuation { get; set; }
            public string Status { get; set; }
            public DateTime DateTime { get; set; }

            private IDiscount _discount;

            public void SetDiscount(IDiscount discount)
            {
                _discount = discount;
            }

            public double GetDiscountedPrice()
            {
                if (_discount == null)
                {
                    return Price; // No discount applied
                }
                return _discount.ApplyDiscount(Price);
            }
        }


    }
}
