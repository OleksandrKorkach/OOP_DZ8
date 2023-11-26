namespace OOP_HW8;

public class FourthTask
{
    interface IPriceable
    {
        void SetPrice(double price);
    }

    interface IDiscountable
    {
        void ApplyDiscount(string discount);
    }

    interface IPromocodeApplicable
    {
        void ApplyPromocode(string promocode);
    }

    interface IColorable
    {
        void SetColor(byte color);
    }

    interface ISizeable
    {
        void SetSize(byte size);
    }
    
    class Book : IPriceable, IDiscountable
    {
        public void SetPrice(double price)
        {
            
        }

        public void ApplyDiscount(string discount)
        {
            
        }
    }

    class UpperClothing : IPriceable, IDiscountable, IColorable, ISizeable
    {
        public void SetPrice(double price)
        {
            
        }

        public void ApplyDiscount(string discount)
        {
            
        }

        public void SetColor(byte color)
        {
            
        }

        public void SetSize(byte size)
        {
            
        }
    }
}