﻿using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    internal interface ICarRepository
    {
        IEnumerable<Car> GetCars();
        Car GetCarById(int carId);
        void InsertCar(Car car);
        void DeleteCar(int  carId);
        void UpdateCar(Car car);
    }
}
