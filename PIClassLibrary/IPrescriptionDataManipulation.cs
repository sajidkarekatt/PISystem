namespace PIClassLibrary
{
    public  interface IPrescriptionDataManipulation<T>
    {
        public void Save(T patient);
        public T? Retrieve(string id);       
        public void Delete(string id);
        public List<T>? RetrieveAll();
        public List<T>? RetrieveAll(string id);

    }
}
