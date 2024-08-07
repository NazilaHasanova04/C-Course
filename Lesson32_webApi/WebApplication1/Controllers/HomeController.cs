using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WebApplication1.Data;
using WebApplication1.Data.Entities;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
       public static List <Employee> employees = new List<Employee> ();
        private  ISingleton _singleton { get; set; }
        private IScoped _scoped { get; set; }
        private IServiceProvider _serviceProvider { get; set; }
        private IConfiguration _config { get; set; }
        private PositionOptions _positionOptions { get; set; }
        private StudentDbContext _studentDbContext;

        public HomeController(ISingleton singleton,IScoped scoped,IServiceProvider serviceProvider,IConfiguration configuration,
            IOptions<PositionOptions> options,StudentDbContext studentDbContext)
        {
            _singleton = singleton;
            _scoped = scoped;
            _serviceProvider = serviceProvider;
            _config = configuration;
            _positionOptions = options.Value;
            _studentDbContext = studentDbContext;
        }
        [HttpGet("GetAll")]
        public async Task<List<Student>> GetAllEmployees()
        {
            return await _studentDbContext.Student.ToListAsync();
        }

        [HttpGet("Guid")]
        public object GetGuid()
        {
            var scoped1 =(IScoped) _serviceProvider.GetService(typeof(IScoped));
            var transient1 = (ITransient)_serviceProvider.GetService(typeof(ITransient));

            var scoped2 = (IScoped)_serviceProvider.GetService(typeof(IScoped));
            var transient2 = (ITransient)_serviceProvider.GetService(typeof(ITransient));

            return new
            {
                singleton= _singleton.id,
                scoped1=scoped1,
                transient1=transient1,

                scoped2 = scoped2,
                transient2 = transient2,
            };
        }


        [HttpGet("employee/{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var employee = await _studentDbContext.Student.FirstOrDefaultAsync(x => x.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateEmployee(Student st)
        {
            await _studentDbContext.Student.AddAsync(st);
           await _studentDbContext.SaveChangesAsync();
            return Created($"/api/Home/employee/{st.Id}",st);
        }
       
        [HttpPut("update")]
        public async Task<Student> UpdateEmployee(int id,Student newemployee)
        {
            var employee = await _studentDbContext.Student.FirstOrDefaultAsync(x=> x.Id == id);
            employee.Name= newemployee.Name;
           await _studentDbContext.SaveChangesAsync();

            return newemployee;
        }
        [HttpDelete("delete")]
        public async Task<Student> DeleteEmployee(int id)
        {
            var employee = await _studentDbContext.Student.FirstOrDefaultAsync(x=>x.Id == id);
            _studentDbContext.Student.Remove(employee);
            await _studentDbContext.SaveChangesAsync();
            return employee;
        }
        [HttpGet("config")]
        public object GetConfig()
        {
            var configurations = new
            {
                ApiKey = _config["ApiKey"],
                key = _config["Key"],
                Positions = _positionOptions
            };
            return configurations;
        }
    }
}
