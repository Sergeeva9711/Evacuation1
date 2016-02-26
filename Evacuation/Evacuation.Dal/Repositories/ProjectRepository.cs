﻿using Evacuation.Dal.Context;
using Evacuation.Dal.Entities;
using Evacuation.Dal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evacuation.Dal.Repositories
{
    class ProjectRepository : IRepository<Project>
    {
       // private ProjectContext db1;
        private UserContext db;

        public ProjectRepository(UserContext context)
        {
            db = context;
        }

        public void Create(Project item)
        {
            db.Projects.Add(item);
        }

        public void Delete(Project item)
        {
            var project = db.Projects.Find(item.ProjectID);
            if (project != null)
                db.Projects.Remove(project);
        }

        public IEnumerable<Project> Find(Func<Project, bool> predicate)
        {
            return db.Projects.Where(predicate).ToList();
        }

        public Project Get(int id)
        {
            return db.Projects.Find(id);
        }

        public IEnumerable<Project> GetAll()
        {
            return db.Projects;
        }

        public void Update(Project item)
        {
            var project = db.Projects.Find(item.ProjectID);
            db.Entry(project).CurrentValues.SetValues(item);
        }
    }
}