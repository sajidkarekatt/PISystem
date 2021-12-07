namespace PIClassLibrary
{
    public class Prescription
    {
        public string? PatientId { get; set; }
        public string? MedicineId { get; set; }
        public string? MedName { get; set; }
        public int Qty { get; set; }
        public DateTime Date { get; set; }
        public string? Desc { get; set; }
    }
}
