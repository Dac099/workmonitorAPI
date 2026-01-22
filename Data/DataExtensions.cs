using System;
using Microsoft.EntityFrameworkCore;

namespace workmonitorAPI.Data;

public static class DataExtensions
{
    public static void AddWorkmonitorDb(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionString));
    }
}
