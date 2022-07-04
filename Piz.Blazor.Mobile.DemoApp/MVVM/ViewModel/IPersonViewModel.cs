using Piz.Blazor.Mobile.DemoApp.MVVM.Model;
using Piz.Blazor.MVVM.ViewModel;
using System.ComponentModel.DataAnnotations;

namespace Piz.Blazor.Mobile.DemoApp.MVVM.ViewModel
{
    public interface IPersonViewModel : IViewModelBase<PersonModel>
    {
        [Required]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [StringLength(10, MinimumLength = 6, ErrorMessage = "The Password range should be 6 to 10")]
        public string Password { get; set; }

        [Display(Name = "BirthDay")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDay { get; set; }     

        public void Save();

        public void Load();
    }
}
