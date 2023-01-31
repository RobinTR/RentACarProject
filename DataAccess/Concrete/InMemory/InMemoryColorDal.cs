using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryColorDal : IColorDal
    {
        List<Color> _colors;

        public InMemoryColorDal()
        {
            _colors = new List<Color>()
            {
                new Color{Id = 1, Name = "Black"},
                new Color {Id = 2, Name = "White"},
                new Color {Id = 3, Name = "Red"}
            };
        }

        public void Add(Color color)
        {
            _colors.Add(color);
        }

        public void Update(Color color)
        {
            Color colorToUpdate = _colors.SingleOrDefault(c=>c.Id == color.Id);

            colorToUpdate.Name = color.Name;
        }

        public void Delete(Color color)
        {
            Color colorToDelete = _colors.SingleOrDefault(c=>c.Id == color.Id);

            _colors.Remove(colorToDelete);
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
