using AxisTrack.Models;
using AxisTrack.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxisTrack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectTasksController : ControllerBase
    {

        private readonly IGenericRepository<ProjectTask> _projectTasksRepository;

        public ProjectTasksController(IGenericRepository<ProjectTask> projectTasksRepository)
        {
            _projectTasksRepository = projectTasksRepository;
        }



        [HttpGet]





        public async Task<ActionResult<List<ProjectTask>>> GetProjectTasks()
        
        
           { 
        
        
        var projectTasks = await _projectTasksRepository.GetAllAsync();


            return Ok(projectTasks);
        
        
       
           }




        //GetTaskByID





        [HttpPost]


        public async Task<ActionResult<ProjectTask>> AddProjectTask(ProjectTask projectTask) 
        
        {

            if (projectTask == null) {


                return BadRequest("The Project doesn't exist");
            
            }

            var createdProjectTask = await _projectTasksRepository.AddAsync(projectTask);



            return CreatedAtAction(nameof(GetProjectTasks), new { id = createdProjectTask.Id }, createdProjectTask);
            
        
        
        }




    }

    
}
