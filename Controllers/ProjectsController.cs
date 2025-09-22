using AxisTrack.Models;
using AxisTrack.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxisTrack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        private readonly IGenericRepository<Project> _projectRepository;

        public ProjectsController(IGenericRepository<Project> projectRepository)
        {
            _projectRepository = projectRepository;
        }




        [HttpGet]



        public async Task<ActionResult<List<Project>>> GetProjects() 
        {

           var projects = await _projectRepository.GetAllAsync();



            return Ok(projects);
        }



        [HttpPost]


        public async Task <ActionResult<Project>> AddProject(Project project)
        {

            if (project == null) return BadRequest("There are currently no projects available at this time");


            var createdProject = await _projectRepository.AddAsync(project);


            return CreatedAtAction(nameof(GetProjects), new {id = createdProject.Id }, createdProject);

        }
    }


}
