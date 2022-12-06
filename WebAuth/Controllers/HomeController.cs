using Microsoft.AspNetCore.Mvc;
using WebAuth.DBContext;
using WebAuth.Models;


namespace WebAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        [Route("getHomeData")]
        public IActionResult getDocks()
        {
            var docks = dbContext.Docks.ToList();
            var customers = dbContext.Customers.ToList();
            var statuses = dbContext.SupportStatuses.ToList();

            dynamic allData = new {
                docks= docks,
                customers=customers,
                statuses=statuses
            };
           // data.dock = docks;

            return Ok(allData);
        }


        [HttpPost]
        [Route("insertJob")]
        public IActionResult insertJob(Job Job)
        {
            //if(customers == null) {
            //    return Ok("Some feild's are empty!");
            //}

            Job obj = new Job()
            {
                Id = Job.Id,
                SupportStatus = Job.SupportStatus,
                Customers = Job.Customers,
                Dock = Job.Dock,
                NoPallets = Job.NoPallets,
                LoadNo = Job.LoadNo,
                startDate = Job.startDate,
                endDate = Job.endDate

            };
            dbContext.Job.Add(obj);
            dbContext.SaveChanges();

            return Ok("Docks Added!");
        }

        [HttpPut]
        [Route("updateJob")]
        public IActionResult UpdateJob([FromBody] Job job)
        {
            var jobs = dbContext.Job.FirstOrDefault(x => x.Id == job.Id);

            Job obj = new Job()
            {
                Id = job.Id,
                SupportStatus = job.SupportStatus,
                Customers = job.Customers,
                Dock = job.Dock,
                NoPallets = job.NoPallets,
                LoadNo = job.LoadNo,
                startDate = job.startDate,
                endDate = job.endDate

            };

            // dock.DockName = docks.DockName;
            dbContext.Update(obj);

            dbContext.SaveChanges();
            return Ok("Jobs updated sucessfull!");
        }



        [HttpDelete]
        [Route("deleteJob/{Id}")]
        public IActionResult deleteJob(Guid Id)
        {
            var dock = dbContext.Job.FirstOrDefault(x => x.Id == Id);

            if (dock == null)
            {
                return Ok("Job not found in Database!");
            }

            dbContext.Job.Remove(dock);
            dbContext.SaveChanges();

            return Ok("Job is delete!");
        }
    }
}
