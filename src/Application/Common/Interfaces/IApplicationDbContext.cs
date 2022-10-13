using AquariumPeek.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AquariumPeek.Application.Common.Interfaces;
public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
