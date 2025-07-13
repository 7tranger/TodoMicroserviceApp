using Microsoft.EntityFrameworkCore;
using TodoService.Models;

namespace TodoService.Data;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
      : base(options) { }

    public DbSet<TodoItem> Todos => Set<TodoItem>();
}
