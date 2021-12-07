using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PIClassLibrary;

namespace PIBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IWebHostEnvironment _hostingEnvironment;

        private readonly string _userDataFile;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public UserController(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
            _userDataFile = _hostingEnvironment.ContentRootPath + @"Data\users.json";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "UserDetails")]
        public List<User>? Get()
        {
            List<User>? users = new List<User>();
            JSonData<User> jSonData = new JSonData<User>(ref users, _userDataFile);
            DataManager<User> dataManager = new DataManager<User>(jSonData);

            users = dataManager.RetrieveAll();
            return users;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        [HttpGet("{email}/{pwd}", Name = "UserAuthentification")]
        public IEnumerable<User>? GetUser(string email, string pwd)
        {
            Authentication authentication = new Authentication(_userDataFile);
            return authentication.IsAuthenticated(email, pwd);
        }

        [HttpDelete("{id}",Name ="DeleteUser")]
        public void DeleteUser(string id)
        {
            List<User>? users = new List<User>();
            JSonData<User> jSonData = new JSonData<User>(ref users, _userDataFile);
            DataManager<User> dataManager = new DataManager<User>(jSonData);

            bool retVal= dataManager.Delete(id);
        }

        [HttpPost(Name ="CreateUser")]
        public void CreateUser(User user)
        {
            List<User>? users = new List<User>();
            JSonData<User> jSonData = new JSonData<User>(ref users, _userDataFile);
            DataManager<User> dataManager = new DataManager<User>(jSonData);

            bool retVal= dataManager.Save(user);
        }
    }
}
