using Api.Models;

namespace Api.Repositories;

public abstract class BaseOfRepositories
{
    protected readonly DatabaseContext _context;
    protected readonly UnitOfWork _unitOfWork;
    public BaseOfRepositories(DatabaseContext context, UnitOfWork unitOfWork)
    {
        _context = context;
        _unitOfWork = unitOfWork;
    }
}