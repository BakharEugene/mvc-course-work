using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_course_work.Models.Entities;
using mvc_course_work.interfaces;
using System.Data.Entity;
namespace mvc_course_work.Models.DAL
{
    public class TeamRepository : IRepository<Team>
    {
        private ApplicationDbContext _applicationDbContext;

        public TeamRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Team> GetAll()
        {
            return _applicationDbContext.Teams.ToList();
        }

        public Team GetById(int? id)
        {
            return _applicationDbContext.Teams.Find(id);
        }

        public void Create(Team item)
        {
            _applicationDbContext.Teams.Add(item);
        }

        public void Update(Team item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Teams.Find(id) != null)
            {
                _applicationDbContext.Teams.Remove(_applicationDbContext.Teams.Find(id));
            }
        }
    }
}
