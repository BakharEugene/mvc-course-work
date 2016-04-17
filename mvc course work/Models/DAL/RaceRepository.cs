using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_course_work.Models.Entities;
using mvc_course_work.interfaces;
using System.Data.Entity;
namespace mvc_course_work.Models.DAL
{
    public class RaceRepository : IRepository<Race>
    {
        private ApplicationDbContext _applicationDbContext;

        public RaceRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Race> GetAll()
        {
            return _applicationDbContext.Races.ToList();
        }

        public Race GetById(int? id)
        {
            return _applicationDbContext.Races.Find(id);
        }

        public void Create(Race item)
        {
            _applicationDbContext.Races.Add(item);
        }

        public void Update(Race item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Races.Find(id) != null)
            {
                _applicationDbContext.Races.Remove(_applicationDbContext.Races.Find(id));
            }
        }
    }
}
