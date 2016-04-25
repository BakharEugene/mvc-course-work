using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_course_work.Models.Entities;
using mvc_course_work.interfaces;
using System.Data.Entity;
namespace mvc_course_work.Models.DAL
{
    public class PodiumRepository : IRepository<Podium>
    {
        private ApplicationDbContext _applicationDbContext;

        public PodiumRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Podium> GetAll()
        {
            return _applicationDbContext.Podiums.ToList();
        }

        public Podium GetById(int? id)
        {
            return _applicationDbContext.Podiums.Find(id);
        }

        public void Create(Podium item)
        {
            _applicationDbContext.Podiums.Add(item);
        }

        public void Update(Podium item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Podiums.Find(id) != null)
            {
                _applicationDbContext.Podiums.Remove(_applicationDbContext.Podiums.Find(id));
            }
        }
    }
}
