using System.Collections.ObjectModel;

namespace HomeMedecine.Models
{
    public class FamilyMember
    {
        public string Name { get; set; }
        public string Age { get; set; }

        public ObservableCollection<MedicineSchedule> MedicineSchedules { get; set; }

        public FamilyMember()
        {
            MedicineSchedules = new ObservableCollection<MedicineSchedule>();
        }
    }
}
