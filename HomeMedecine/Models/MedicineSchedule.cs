using System.Collections.ObjectModel;

namespace HomeMedecine.Models
{
    public class MedicineSchedule
    {
        public string MedicineName { get; set; }
        public int TimesPerDay { get; set; }
        public TimeSpan[] DosesTimes { get; set; }
        public ObservableCollection<MedicineLog> Logs { get; set; }

        public MedicineSchedule()
        {
            Logs = new ObservableCollection<MedicineLog>();
        }

        public void CalculateDosesTimes()
        {
            DosesTimes = new TimeSpan[TimesPerDay];
        }
    }
}
