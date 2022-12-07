using _3BusinessLogicLayer.Interfaces;
using _3BusinessLogicLayer.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace _3BusinessLogicLayer.Ioc
{
    public static class Init
    {
        public static void InitializeDependencies(IServiceCollection services, IConfiguration configuration)
        {
                      
            // Services
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ISubjectService, SubjectService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IPractitionerService, PractitionerService>();
            services.AddScoped<IClientService, ClientService>(); 
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<ILecturerService, LecturerService>();
            services.AddScoped<IUnitService, UnitService>();
            //services.AddScoped<ICategoryService, CategoryService>();

        }
    }
}
