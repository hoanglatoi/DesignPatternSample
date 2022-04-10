using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Creational.BuilderPattern
{
    #region Product  class
    public class Order
    {
        private OrderType orderType;
        private BreadType breadType;
        private SauceType sauceType;
        private VegetableType vegetableType;
        private string? other;

        public Order(OrderType orderType, BreadType breadType, SauceType sauceType, VegetableType vegetableType, string? other)
        {
            this.orderType = orderType;
            this.breadType = breadType;
            this.sauceType = sauceType;
            this.vegetableType = vegetableType;
            this.other = other;
        }
        public override String ToString()
        {
            return "Order [orderType=" + orderType + ", breadType=" + breadType + ", sauceType=" + sauceType
                    + ", vegetableType=" + vegetableType + ", other=" + other  + "]";
        }

        public OrderType getOrderType()
        {
            return orderType;
        }

        public BreadType getBreadType()
        {
            return breadType;
        }

        public SauceType getSauceType()
        {
            return sauceType;
        }

        public VegetableType getVegetableType()
        {
            return vegetableType;
        }

        public string? getOther()
        {
            return this.other;
        }

    }

    public enum BreadType
    {
        SIMPLE, OMELETTE, FRIED_EGG, GRILLED_FISH, PORK, BEEF
    }

    public enum OrderType
    {
        ON_SITE, TAKE_AWAY
    }

    public enum SauceType
    {
        SOY_SAUCE, FISH_SAUCE, OLIVE_OIL, KETCHUP, MUSTARD
    }

    public enum VegetableType
    {
        CUCUMBER, SALAD, TOMATO
    }
    #endregion

    #region Builder class

    public interface IOrderBuilder
    {

        IOrderBuilder SetOrderType(OrderType orderType);

        IOrderBuilder SetOrderBread(BreadType breadType);

        IOrderBuilder SetOrderSauce(SauceType sauceType);

        IOrderBuilder SetOrderVegetable(VegetableType vegetableType);

        IOrderBuilder SetOrderOther(string other);

        Order build();

    }

    public class FastFoodOrderBuilder : IOrderBuilder
    {
        private OrderType orderType;
        private BreadType breadType;
        private SauceType sauceType;
        private VegetableType vegetableType;
        private string? other = null;

        public IOrderBuilder SetOrderType(OrderType orderType)
        {
            this.orderType = orderType;
            return this;
        }

        public IOrderBuilder SetOrderBread(BreadType breadType)
        {
            this.breadType = breadType;
            return this;
        }

        public IOrderBuilder SetOrderSauce(SauceType sauceType)
        {
            this.sauceType = sauceType;
            return this;
        }

        public IOrderBuilder SetOrderVegetable(VegetableType vegetableType)
        {
            this.vegetableType = vegetableType;
            return this;
        }

        public IOrderBuilder SetOrderOther(string other)
        {
            this.other = other;
            return this;
        }

        public Order build()
        {
            return new Order(orderType, breadType, sauceType, vegetableType, other);
        }
    }
    #endregion
}
