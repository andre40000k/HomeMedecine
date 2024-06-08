using HomeMedecine.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace HomeMedecine.ViewModel
{
    public class FamilyViewModel : ViewModelBase
    {
        public ObservableCollection<FamilyMember> FamilyMembers { get; set; }
        public ICommand AddFamilyMemberCommand { get; set; }

        public FamilyViewModel()
        {
            FamilyMembers = new ObservableCollection<FamilyMember>();
            AddFamilyMemberCommand = new RelayCommand(AddFamilyMember);
        }

        private void AddFamilyMember(object parameter)
        {
            FamilyMembers.Add(new FamilyMember { Name = "New Member" });
        }
    }
}
