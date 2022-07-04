using Piz.Blazor.Mobile.DemoApp.MVVM.Model;
using Piz.Blazor.MVVM.ViewModel;

namespace Piz.Blazor.Mobile.DemoApp.MVVM.ViewModel
{
    public class PersonViewModel : TViewModelBase<PersonModel>, IPersonViewModel
    {
        private string name;
        private string surname;
        private string password;
        private DateTime birthDay;

        private PersonModel person;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public DateTime BirthDay
        {
            get => birthDay;
            set
            {
                birthDay = value;
                OnPropertyChanged("BirthDay");
            }
        }

        public void Load()
        {
            //FakeData
            person = new PersonModel() { Name = "Diego", Surname = "Pizzoli", Password = "123456789AA", BirthDay = new DateTime(1977, 1, 12) };

            MappingModelToViewModel<PersonViewModel>(person);
        }

        public void Save()
        {
            person = MappingViewModelToModel<PersonViewModel>();
            Console.WriteLine($"Name Saved: {person.Name}");
        }
    }
}
