﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brands;

        public InMemoryBrandDal()
        {
            _brands = new List<Brand>()
            {
                new Brand{Id = 1, Name = "Tesle"},
                new Brand {Id = 2, Name = "Audi"},
                new Brand {Id = 3, Name = "Volvo"}
            };
        }
        public void Add(Brand brand)
        {
            _brands.Add(brand);
        }

        public void Update(Brand brand)
        {
            Brand brandToUpdate = _brands.SingleOrDefault(b=>b.Id == brand.Id);

            brandToUpdate.Name = brand.Name;
        }

        public void Delete(Brand brand)
        {
            Brand brandToDelete = _brands.SingleOrDefault(b=>b.Id == brand.Id);

            _brands.Remove(brandToDelete);
        }

        public List<Brand> GetAll()
        {
            return _brands;
        }

        public Brand GetById(int id)
        {
            return _brands.SingleOrDefault(b=>b.Id == id);
        }
    }
}
