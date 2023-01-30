using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBrandDal
    {
        void Add(Brand brand);
        void Update(Brand brand);
        void Delete(Brand brand);
        List<Brand> GetAll();
        Brand GetById(int id);
    }
}
