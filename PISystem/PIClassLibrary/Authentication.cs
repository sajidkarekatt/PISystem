using System.Text.Json;

namespace PIClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Authentication
    {
        private  string FilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        public Authentication(string filePath)
        {
            this.FilePath = filePath;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<User>? ReadData()
        {
            List<User>? persons = null;
            using (Stream stream = new FileStream(FilePath, FileMode.Open,
                                        FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                string fileContents;
                using (StreamReader reader = new StreamReader(stream))
                {
                    fileContents = reader.ReadToEnd();
                }
                var options = new JsonSerializerOptions { WriteIndented = true };
                persons = JsonSerializer.Deserialize<List<User>>(fileContents, options);
            }
            return persons;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public IEnumerable<User>? IsAuthenticated(string email,string pwd)
        {
            List<User> ?  userLists= ReadData();
            if (userLists == null) return null;
            IEnumerable<User>? user = userLists.Where(user => user.Email == email && user.PW == pwd);
            return user;           
        }
    }
}
