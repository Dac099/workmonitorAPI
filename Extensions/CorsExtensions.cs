using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace workmonitorAPI.Extensions;

public static class CorsExtensions
{
  private const string DefaultCorsPolicyName = "DefaultCors";

  public static WebApplicationBuilder AddDefaultCors(this WebApplicationBuilder builder)
  {
    builder.Services.AddCors(options =>
    {
      options.AddPolicy(DefaultCorsPolicyName, policy =>
          {
          policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
    });

    return builder;
  }

  public static WebApplication UseDefaultCors(this WebApplication app)
  {
    app.UseCors(DefaultCorsPolicyName);
    return app;
  }
}
