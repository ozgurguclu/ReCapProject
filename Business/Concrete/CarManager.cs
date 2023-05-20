﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
                _carDal.Add(car);
            else
                Console.WriteLine("Araba eklenemedi");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return new List<Car>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return new List<Car>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
