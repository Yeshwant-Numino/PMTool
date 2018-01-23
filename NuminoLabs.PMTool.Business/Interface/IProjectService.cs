using NuminoLabs.PMTool.Model.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace NuminoLabs.PMTool.Business.Interface
{
    public interface IProjectService
    {
        IEnumerable<Project> GetProjects();
        Project GetProject(int id);
        void CreateProject(Project project);
        //void SaveProject();
    }
}
