using Api.Models;
using Api.Libs;

namespace Api.Repositories;

public class ProjectRepository : BaseOfRepositories, IProjectRepository
{
    public ProjectRepository(DatabaseContext context, UnitOfWork unitOfWork) : base(context, unitOfWork)
    {
    }

    public Project Add(Project project)
    {
        _context.Projects.Add(project);
        _context.SaveChanges();
        return project;
    }

    public List<Project> GetProjects() => _context.Projects.Paginate(new PaginationDetails());
}