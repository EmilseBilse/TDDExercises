using System;

namespace BusExercise1
{
    public class BusPrices : IBusPrices
    {
        private const int Fee = 130;
        private readonly double _under100Rate = 3.20;
        private readonly double _under12Pass100500Rate = 2.75;
        private readonly double _over12Pass100500Rate = 3.00;
        private readonly double _over500KmRate = 2.25;
        private double _totalPrice = 0;
        
        public double TotalCost(int noOfPassengers, int kilometer)
        {
            if (kilometer < 100)
            {
                Under100Km(kilometer);
            }else if (kilometer < 500 && noOfPassengers < 12)
            {
                Under12PassUnder500(kilometer);
            }else if (kilometer < 500)
            {
                Over12PassUnder500(kilometer);
            }
            else
            {
                Over500Km(kilometer);
            }
            
            return _totalPrice;
        }

        private void Under100Km(int km)
        {
            _totalPrice = km * _under100Rate + Fee;
        }

        private void Under12PassUnder500(int km)
        {
            _totalPrice = km * _under12Pass100500Rate + Fee;
        }
        
        private void Over12PassUnder500(int km)
        {
            _totalPrice = km * _over12Pass100500Rate + Fee;
        }

        private void Over500Km(int km)
        {
            _totalPrice = km * _over500KmRate + Fee;
        }
        
    }
}