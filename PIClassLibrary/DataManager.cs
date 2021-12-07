namespace PIClassLibrary
{

    #region DataManagerPerson
    /// <summary>
    /// class for managing data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataManager<T> where T : Person
    {
        IPersonalDataManipulation<T> Manipulation;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataManipulation"></param>
        public DataManager(IPersonalDataManipulation<T> dataManipulation)
        {
            Manipulation = dataManipulation;
        }
        /// <summary>
        /// retrieving all data without any condition
        /// </summary>
        /// <returns></returns>
        public List<T>? RetrieveAll()
        {
            try
            {
                return Manipulation.RetrieveAll();
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// delete data as per the condition
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            try
            {
                Manipulation.Delete(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// save the given data
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool Save(T person)
        {
            try
            {
                Manipulation.Save(person);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// retrieve the specified data
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool Retreive(T person)
        {
            try
            {
                Manipulation.Retrieve(person.ID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
    #endregion

    #region DataManagerMedicine
    public class MedicineDataManager<T> where T : Medicine
    {
        IMedicineDataManipulation<T> Manipulation;

        public MedicineDataManager(IMedicineDataManipulation<T> dataManipulation)
        {
            Manipulation = dataManipulation;
        }
        /// <summary>
        /// retrieving all data without any condition
        /// </summary>
        /// <returns></returns>
        public List<T>? RetrieveAll()
        {
            try
            {
                return Manipulation.RetrieveAll();
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// delete data as per the condition
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            try
            {
                Manipulation.Delete(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// save the given data
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        public bool Save(T medicine)
        {
            try
            {
                Manipulation.Save(medicine);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// retrieve the specified data
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        public bool Retreive(T medicine)
        {
            try
            {
                Manipulation.Retrieve(medicine.Id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

    #endregion

    #region DataManagerPrescription

    public class PrescriptionDataManager<T> where T : Prescription
    {
        IPrescriptionDataManipulation<T> Manipulation;

        public PrescriptionDataManager(IPrescriptionDataManipulation<T> dataManipulation)
        {
            Manipulation = dataManipulation;
        }
        /// <summary>
        /// retrieving all data without any condition
        /// </summary>
        /// <returns></returns>
        public List<T>? RetrieveAll()
        {
            try
            {
                return Manipulation.RetrieveAll();
            }
            catch (Exception)
            {
                return null;
            }
        }
        /// <summary>
        /// delete data as per the condition
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(string id)
        {
            try
            {
                Manipulation.Delete(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// save the given data
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        public bool Save(T pres)
        {
            try
            {
                Manipulation.Save(pres);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        /// <summary>
        /// retrieve the specified data
        /// </summary>
        /// <param name="medicine"></param>
        /// <returns></returns>
        public bool Retreive(T pres)
        {
           throw new NotImplementedException();
        }

        public List<T>? RetrieveAll(string patientid)
        {

            try 
            {
                return Manipulation.RetrieveAll(patientid);                    
            }
            catch(Exception) 
            {
                return null;
            }
        }

    }
    #endregion
}
