namespace HomeMedecine.Models
{
    public class MedicineLog
    {
        public DateTime Date { get; set; }
        public bool Taken { get; set; }
        public bool Skipped { get; set; }
    }
}
