using System.Text.Json;

namespace PIClassLibrary
{
    #region JSonPerson
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JSonData<T> : IPersonalDataManipulation<T> where T : Person
    {
        string FilePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="filePath"></param>
        public JSonData(ref List<T> ts, string filePath)
        {
            this.FilePath = filePath;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<T>? ReadData()
        {
            List<T>? persons = null;
            using (Stream stream = new FileStream(FilePath, FileMode.Open,
                                        FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                string fileContents;
                using (StreamReader reader = new StreamReader(stream))
                {
                    fileContents = reader.ReadToEnd();
                }
                var options = new JsonSerializerOptions { WriteIndented = true };
                persons = JsonSerializer.Deserialize<List<T>>(fileContents, options);
            }
            return persons;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        public void Save(T person)
        {
            List<T>? persons = ReadData();
            if (persons != null)
            {
                persons.Add(person);
                SaveData(persons);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="persons"></param>
        public void SaveData(List<T> persons)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(persons, options);
            File.WriteAllText(FilePath, jsonString);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            List<T>? persons = ReadData();
            if (persons != null)
            { 
                T? dperson = persons.Find(p => p.ID == id);
                if (dperson != null)
                {
                    persons.Remove(dperson);
                    this.SaveData(persons);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T? Retrieve(string id)
        {
            List<T>? persons = ReadData();
            if (persons != null)
                return persons.Find(p => p.ID == id);
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T>? RetrieveAll()
        {
            return ReadData();
        }
    }

    #endregion

    #region JsonMedicine
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JSonDataMed<T> : IMedicineDataManipulation<T> where T : Medicine
    {
        string FilePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="filePath"></param>
        public JSonDataMed(ref List<T> ts, string filePath)
        {
            this.FilePath = filePath;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<T>? ReadData()
        {
            List<T>? medicines = null;
            using (Stream stream = new FileStream(FilePath, FileMode.Open,
                                        FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                string fileContents;
                using (StreamReader reader = new StreamReader(stream))
                {
                    fileContents = reader.ReadToEnd();
                }
                var options = new JsonSerializerOptions { WriteIndented = true };
                medicines = JsonSerializer.Deserialize<List<T>>(fileContents, options);
            }
            return medicines;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="medicine"></param>
        public void Save(T medicine)
        {
            List<T>? medicines = ReadData();
            if (medicines != null)
            {
                medicines.Add(medicine);
                SaveData(medicines);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="medicines"></param>
        public void SaveData(List<T> medicines)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(medicines, options);
            File.WriteAllText(FilePath, jsonString);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            List<T>? medicines = ReadData();
            if (medicines != null)
            {
                T? dmedicine = medicines.Find(p => p.Id == id);
                if (dmedicine != null)
                {
                    medicines.Remove(dmedicine);
                    this.SaveData(medicines);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T? Retrieve(string id)
        {
            List<T>? medicines = ReadData();
            if (medicines != null)
                return medicines.Find(p => p.Id == id);
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T>? RetrieveAll()
        {
            return ReadData();
        }
    }

    #endregion 

    #region JsonPrescription
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class JSonDataPresc<T> : IPrescriptionDataManipulation<T> where T : Prescription
    {
        string FilePath;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ts"></param>
        /// <param name="filePath"></param>
        public JSonDataPresc(ref List<T> ts, string filePath)
        {
            this.FilePath = filePath;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private List<T>? ReadData()
        {
            List<T>? prescriptions= null;
            using (Stream stream = new FileStream(FilePath, FileMode.Open,
                                        FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                string fileContents;
                using (StreamReader reader = new StreamReader(stream))
                {
                    fileContents = reader.ReadToEnd();
                }
                var options = new JsonSerializerOptions { WriteIndented = true };
                prescriptions = JsonSerializer.Deserialize<List<T>>(fileContents, options);
            }
            return prescriptions;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prescription"></param>
        public void Save(T prescription)
        {
            List<T>? prescriptions = ReadData();
            if (prescriptions != null)
            {
                prescriptions.Add(prescription);
                SaveData(prescriptions);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prescriptions"></param>
        public void SaveData(List<T> prescriptions)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(prescriptions, options);
            File.WriteAllText(FilePath, jsonString);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void Delete(string id)
        {
            List<T>? prescriptions = ReadData();
            if (prescriptions != null)
            {
                T? dprescription = prescriptions.Find(p => p.PatientId == id);
                if (dprescription != null)
                {
                    prescriptions.Remove(dprescription);
                    this.SaveData(prescriptions);
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T? Retrieve(string id)
        {
            List<T>? dprescriptions = ReadData();
            if (dprescriptions != null)
                return dprescriptions.Find(p => p.PatientId == id);
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<T>? RetrieveAll()
        {
            return ReadData();
        }

        public List<T>? RetrieveAll(string id)
        {
            return (List<T>?)ReadData().Where(p => p.PatientId == id);   
        }
    }

    #endregion
}
