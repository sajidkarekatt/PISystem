namespace PIClassLibrary
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class XMLData<T> : IPersonalDataManipulation<T> where T : Person
    {
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public T? Retrieve(string id)
        {
            throw new NotImplementedException();
        }

        public List<T>? RetrieveAll()
        {
            throw new NotImplementedException();
        }

        public void Save(T patient)
        {
            throw new NotImplementedException();
        }
    }
}
