using Piz.Blazor.Mobile.DemoApp.MVVM.Model;
using Piz.Blazor.MVVM.ViewModel;

namespace Piz.Blazor.Mobile.DemoApp.MVVM.ViewModel
{
    public interface IPersonViewModel : IViewModelBase<PersonModel>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Password { get; set; }

        public DateTime BirthDay { get; set; }

        public void Save();

        public void Load();
    }
}
