using Piz.Blazor.Mobile.DemoApp.MVVM.Model;
using Piz.Blazor.MVVM.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace Piz.Blazor.Mobile.DemoApp.MVVM.ViewModel
{
    public class PersonViewModel : TViewModelBase<PersonModel>, IPersonViewModel
    {
        private string name;
        private string surname;
        private string password;
        private DateTime birthDay;

        private PersonModel person;

        public PersonViewModel()
        {
            IsFirstLoad = true;
        }

        [Required]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string Name
        {
            get => name;
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        [Required]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
                OnPropertyChanged("Surname");
            }
        }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "The Password range should be 6 to 10")]
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        [Display(Name = "BirthDay")]
        [DataType(DataType.DateTime)]
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
            IsFirstLoad = true;
            //FakeData
            person = new PersonModel() { Name = "Diego", Surname = "Pizzoli", Password = "123456789AA", BirthDay = new DateTime(1977, 1, 12) };

            MappingModelToViewModel<PersonViewModel>(person);

            IsFirstLoad = false;
        }

        public void Save()
        {
            person = MappingViewModelToModel<PersonViewModel>();
            Console.WriteLine($"Name Saved: {person.Name}");
        }
    }
}
