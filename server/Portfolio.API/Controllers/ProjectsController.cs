using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Portfolio.API.Models.DTOs;
using Portfolio.API.Models.Post;
using Portfolio.Core.Entities;
using Portfolio.Core.Services;
using Portfolio.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Portfolio.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {

        private readonly IProjectService _projectService;
        private readonly IMapper _mapper;

        public ProjectsController(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }


        // GET: api/<ProjectsController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var projects = await _projectService.GetAllAsync(); 
            return Ok(_mapper.Map<IEnumerable<ProjectDto>>(projects));  
        }

        // GET api/<ProjectsController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var project = await _projectService.GetByIdAsync(id);   
            if (project == null) 
                return NotFound();
            return Ok(project);
        }

        // POST api/<ProjectsController>

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProjectPostModel project)
        {
            var projectToAdd = _mapper.Map<Project>(project);
            var addedProject = await _projectService.AddAsync(projectToAdd);
            var newProject = await _projectService.GetByIdAsync(addedProject.Id);
            var projectDto = _mapper.Map<ProjectDto>(newProject);
            return Ok(projectDto);
        }



        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProjectPostModel project)
        {
            var existProject = await _projectService.GetByIdAsync(id);
            if (existProject is null)
                return NotFound();

            _mapper.Map(project, existProject);
            await _projectService.UpdateAsync(id, existProject);
            return Ok(_mapper.Map<ProjectDto>(existProject));
        }



        // DELETE api/<ProjectsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _projectService.DeleteAsync(id);
            if(deleted == null)
                return NotFound();
            return Ok(deleted);
        }
    }
}
