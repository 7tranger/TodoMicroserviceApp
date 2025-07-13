using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TodoService.Data;

namespace TodoService.Data
{
    public class TodoContextFactory : IDesignTimeDbContextFactory<TodoContext>
    {
        public TodoContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TodoContext>();
            // здесь можно взять строку подключения прямо из кода,
            // либо прочитать из appsettings.json, но для простоты:
            builder.UseSqlServer("Server=localhost;Database=TodoDb;User Id=sa;Password=Your_password123;");

            return new TodoContext(builder.Options);
        }
    }
}
