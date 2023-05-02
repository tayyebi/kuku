using Api.Models;

namespace Api.Repositories;

public interface IProjectRepository
{
    Project Add(Project project);
    List<Project> GetProjects();
}