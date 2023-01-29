using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HomeTasksCS5
{
    internal class Car:Vehicle
    {

        public byte FuelCapacity;
        public byte CurrentFuel;


        public void AddFuel(byte fuel)
        {
            FuelCapacity = 70;
            if (fuel <= FuelCapacity)
            {
                this.CurrentFuel += fuel;
            }
        }

        //public void AddFuel(byte fuel)
        //{
        //    FuelCapacity = 70;
        //    do
        //    {
        //        if(FuelCapacity<70)
        //        this.CurrentFuel += fuel;
        //    }while(fuel<=FuelCapacity);
        //}
    }
}
