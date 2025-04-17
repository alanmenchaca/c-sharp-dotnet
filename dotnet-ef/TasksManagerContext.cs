using dotnet_ef.models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_ef;

public class TasksManagerContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Tasks> Tasks { get; set; }

    public TasksManagerContext(DbContextOptions<TasksManagerContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Category> categoriesInit =
        [
            new Category
            {
                CategoryId = Guid.Parse("118eefa8-c6d3-4d20-a591-537931bd2e32"),
                CategoryName = "Pending Activities",
                Description = "Activities that are pending",
                Weight = 20
            },
            new Category
            {
                CategoryId = Guid.Parse("118eefa8-c6d3-4d20-a591-537931bd2ef2"),
                CategoryName = "Personal Activities",
                Description = "Activities that are personal",
                Weight = 50
            }
        ];

        List<Tasks> tasksInit =
        [
            new Tasks()
            {
                TaskId = Guid.Parse("118eefa8-c6d3-4d20-a591-537931bd2e17"),
                Title = "Task 1",
                Description = "Description of Task 1",
                Priority = Priority.Medium,
                CreatedAt = new DateTime(2025, 1, 5, 8, 30, 52, DateTimeKind.Local),
                CategoryId = Guid.Parse("118eefa8-c6d3-4d20-a591-537931bd2e32")
            },
            new Tasks()
            {
                TaskId = Guid.Parse("118eefa8-c6d3-4d20-a591-537931bd2e22"),
                Title = "Task 2",
                Description = "Description of Task 2",
                Priority = Priority.Low,
                CreatedAt = new DateTime(2025, 1, 5, 8, 30, 52, DateTimeKind.Local),
                CategoryId = Guid.Parse("118eefa8-c6d3-4d20-a591-537931bd2ef2")
            }
        ];

        // using Fluent API to configure the model
        modelBuilder.Entity<Category>(category =>
        {
            category.ToTable("Category");
            category.HasKey(c => c.CategoryId);
            category.Property(c => c.CategoryName).HasMaxLength(150).IsRequired();
            category.Property(c => c.Description).HasMaxLength(150).IsRequired();
            category.Property(c => c.Weight);
            category.HasData(categoriesInit);
        });

        modelBuilder.Entity<Tasks>(task =>
        {
            task.ToTable("Task");
            task.HasKey(t => t.TaskId);
            task.Property(t => t.Title).HasMaxLength(200).IsRequired();
            task.Property(t => t.Description);
            task.Ignore(t => t.Summary);
            task.Property(t => t.Priority).IsRequired();
            task.Property(t => t.CreatedAt);
            task.HasOne(t => t.Category).WithMany(c => c.Tasks)
                .HasForeignKey(t => t.CategoryId);
            task.HasData(tasksInit);
        });
    }
}