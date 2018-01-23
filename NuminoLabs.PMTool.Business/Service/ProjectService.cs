using NuminoLabs.PMTool.Business.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using NuminoLabs.PMTool.Model.Entity;
using NuminoLabs.PMTool.Data.Infrastructure;

namespace NuminoLabs.PMTool.Business.Service
{
    public class ProjectService : IProjectService
    {
        private IRepository<Project> _projectRepo;

        public ProjectService(IRepository<Project> projectRepo)
        {
            _projectRepo = projectRepo;
        }
        public void CreateProject(Project project)
        {
            _projectRepo.Insert(project);
        }

        public Project GetProject(int id)
        {
            return _projectRepo.Get(id);
        }

        public IEnumerable<Project> GetProjects()
        {
            return _projectRepo.GetAll();
        }

        //public void SaveProject()
        //{
        //    _unitOfWork.Commit();
        //}
    }
}
