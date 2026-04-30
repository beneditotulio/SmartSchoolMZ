using Microsoft.Extensions.DependencyInjection;
using SmartSchoolMz.Application.Interfaces;
using SmartSchoolMz.Application.Services;

namespace SmartSchoolMz.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAlunoService, AlunoService>();
        services.AddScoped<ITurmaService, TurmaService>();
        services.AddScoped<IMatriculaService, MatriculaService>();
        services.AddScoped<IAcademicProcessService, AcademicProcessService>();

        return services;
    }
}
