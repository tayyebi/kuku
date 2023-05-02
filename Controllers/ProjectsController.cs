    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Api.Models;
    using Api.Repositories;

    namespace Api.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ProjectsController : ControllerBase
        {
            IProjectRepository _projectRepository;
            public ProjectsController(IProjectRepository projectRepository)
            {
                _projectRepository = projectRepository;
            }

            // GET: api/Projects
            [HttpGet]
            public async Task<ActionResult<IEnumerable<Project>>> GetProjects()
            {
            //   if (_context.Projects == null)
            //   {
            //       return NotFound();
            //   }
            //     return await _context.Projects.ToListAsync();
            return null;
            }

            // GET: api/Projects/5
            [HttpGet("{id}")]
            public async Task<ActionResult<Project>> GetProject(long id)
            {
                return null;
            //   if (_context.Projects == null)
            //   {
            //       return NotFound();
            //   }
            //     var project = await _context.Projects.FindAsync(id);

            //     if (project == null)
            //     {
            //         return NotFound();
            //     }

            //     return project;
            }

            // PUT: api/Projects/5
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPut("{id}")]
            public async Task<IActionResult> PutProject(long id, Project project)
            {
                return null;

                // if (id != project.Id)
                // {
                //     return BadRequest();
                // }

                // _context.Entry(project).State = EntityState.Modified;

                // try
                // {
                //     await _context.SaveChangesAsync();
                // }
                // catch (DbUpdateConcurrencyException)
                // {
                //     if (!ProjectExists(id))
                //     {
                //         return NotFound();
                //     }
                //     else
                //     {
                //         throw;
                //     }
                // }

                // return NoContent();
            }

            // POST: api/Projects
            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
            [HttpPost]
            public async Task<ActionResult<Project>> PostProject(Project project)
            {
                return null;

            //   if (_context.Projects == null)
            //   {
            //       return Problem("Entity set 'DatabaseContext.Projects'  is null.");
            //   }
            //     _context.Projects.Add(project);
            //     await _context.SaveChangesAsync();

            //     return CreatedAtAction("GetProject", new { id = project.Id }, project);
            // }

            // // DELETE: api/Projects/5
            // [HttpDelete("{id}")]
            // public async Task<IActionResult> DeleteProject(long id)
            // {
            //     if (_context.Projects == null)
            //     {
            //         return NotFound();
            //     }
            //     var project = await _context.Projects.FindAsync(id);
            //     if (project == null)
            //     {
            //         return NotFound();
            //     }

            //     _context.Projects.Remove(project);
            //     await _context.SaveChangesAsync();

            //     return NoContent();
            }

            private bool ProjectExists(long id)
            {
                return false;
                // return (_context.Projects?.Any(e => e.Id == id)).GetValueOrDefault();
            }
        }
    }
