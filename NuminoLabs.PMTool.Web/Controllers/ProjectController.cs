using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NuminoLabs.PMTool.Business.Interface;
using NuminoLabs.PMTool.Model.Entity;

namespace NuminoLabs.PMTool.Web.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectservice;
        public ProjectController(IProjectService projectservice)
        {
            _projectservice = projectservice;
        }

        public IActionResult ListProjects()
        {
            var projects = _projectservice.GetProjects().ToList();
            return View(projects);
        }
        public IActionResult CreateProject()
        {
            var newProject = new Project();
            return View(newProject);
        }
        [HttpPost]
        public IActionResult CreateProject(Project project)
        {
            _projectservice.CreateProject(project);
            return RedirectToAction("ListProjects");
        }
    }
}