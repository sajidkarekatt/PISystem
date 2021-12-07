using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIClassLibrary;

namespace PIBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public PatientController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "PatientDetails")]
        public List<Patient>? Get()
        {

            string userDataFile = _hostingEnvironment.ContentRootPath + @"Data\patients.json";
            List<Patient>? patients = new List<Patient>();
            JSonData<Patient> jSonData = new JSonData<Patient>(ref patients, userDataFile);
            DataManager<Patient> dataManager = new DataManager<Patient>(jSonData);

            patients = dataManager.RetrieveAll();
            return patients;
        }

    }
}
