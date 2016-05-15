using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using mvc_course_work.Models.Entities;
using mvc_course_work.interfaces;
using System.Data.Entity;
namespace mvc_course_work.Models.DAL
{
    public class UnitOfWork : IDisposable
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        private DriverRepository driverRepository;
        private RaceRepository raceRepository;
        private TeamRepository teamRepository;
        private VideoRepository videoRepository;

       
        public DriverRepository Drivers
        {
            get
            {
                if (driverRepository == null)
                    driverRepository = new DriverRepository(db);
                return driverRepository;
            }
        }
        public RaceRepository Races
        {
            get
            {
                if (raceRepository == null)
                    raceRepository = new RaceRepository(db);
                return raceRepository;
            }
        }
        public VideoRepository Videos
        {
            get
            {
                if (videoRepository == null)
                    videoRepository = new VideoRepository(db);
                return videoRepository;
            }
        }
        public TeamRepository Teams
        {
            get
            {
                if (teamRepository == null)
                    teamRepository = new TeamRepository(db);
                return teamRepository;
            }
        }
       
        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}