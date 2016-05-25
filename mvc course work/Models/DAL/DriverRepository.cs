using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_course_work.Models.Entities;
using mvc_course_work.interfaces;
using System.Data.Entity;
namespace mvc_course_work.Models.DAL
{
    public class DriverRepository : IRepository<Driver>
    {
        private ApplicationDbContext _applicationDbContext;

        public DriverRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Driver> GetAll()
        {
            List<Driver> drivers = _applicationDbContext.Drivers.ToList();
            IEnumerable<Driver> driver = drivers.OrderBy(x => x.number);
            return driver.ToList();
        }

        public Driver GetById(int? id)
        {
            return _applicationDbContext.Drivers.Find(id);
        }

        public void Create(Driver item)
        {
            _applicationDbContext.Drivers.Add(item);
        }

        public void Update(Driver item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Drivers.Find(id) != null)
            {
                _applicationDbContext.Drivers.Remove(_applicationDbContext.Drivers.Find(id));
            }
        }
    }
}
