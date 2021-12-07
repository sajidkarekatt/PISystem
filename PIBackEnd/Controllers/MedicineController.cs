using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIClassLibrary;

namespace PIBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public MedicineController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "MedicineDetails")]
        public List<Medicine>? Get()
        {

            string userDataFile = _hostingEnvironment.ContentRootPath + @"Data\medicines.json";
            List<Medicine>? users = new List<Medicine>();
            JSonDataMed<Medicine> jSonData = new JSonDataMed<Medicine>(ref users, userDataFile);
            MedicineDataManager<Medicine> dataManager = new MedicineDataManager<Medicine>(jSonData);

            users = dataManager.RetrieveAll();
            return users;
        }
    }
}
