using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_course_work.Models.Entities;
using mvc_course_work.interfaces;
using System.Data.Entity;
namespace mvc_course_work.Models.DAL
{
    public class VideoRepository : IRepository<Video>
    {
        private ApplicationDbContext _applicationDbContext;

        public VideoRepository(ApplicationDbContext context)
        {
            this._applicationDbContext = context;
        }

        public IEnumerable<Video> GetAll()
        {
            return _applicationDbContext.Video.ToList();
        }

        public Video GetById(int? id)
        {
            return _applicationDbContext.Video.Find(id);
        }

        public void Create(Video item)
        {
            _applicationDbContext.Video.Add(item);
        }

        public void Update(Video item)
        {
            _applicationDbContext.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            if (_applicationDbContext.Video.Find(id) != null)
            {
                _applicationDbContext.Video.Remove(_applicationDbContext.Video.Find(id));
            }
        }
    }
}
