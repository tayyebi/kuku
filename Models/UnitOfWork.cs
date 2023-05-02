namespace Api.Models;

public class UnitOfWork
{
    private readonly DatabaseContext _context;

    public UnitOfWork(DatabaseContext context) =>
        _context = context;
        
    public virtual async Task SaveChangesAsync() =>
        await _context.SaveChangesAsync();
}