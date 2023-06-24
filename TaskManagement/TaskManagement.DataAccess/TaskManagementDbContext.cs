﻿using Microsoft.EntityFrameworkCore;

namespace TaskManagement.DataAccess;

public class TaskManagementDbContext:DbContext
{
    public TaskManagementDbContext(DbContextOptions<TaskManagementDbContext>options):base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaskManagementDbContext).Assembly);
    }
}