using Microsoft.AspNetCore.Builder;
using workmonitorAPI.Services;
using workmonitorAPI.Services.Interfaces;

namespace workmonitorAPI.Extensions;

public static class ProjectsExtensions
{
    public static WebApplicationBuilder RegisterProjectsServices(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IWorkspaceService, WorkspaceService>();
        builder.Services.AddScoped<IBoardService, BoardService>();
        builder.Services.AddScoped<IGroupService, GroupService>();
        builder.Services.AddScoped<IColumnService, ColumnService>();
        builder.Services.AddScoped<IItemService, ItemService>();
        builder.Services.AddScoped<ITableValueService, TableValueService>();
        builder.Services.AddScoped<IProyectService, ProyectService>();

        return builder;
    }
}
