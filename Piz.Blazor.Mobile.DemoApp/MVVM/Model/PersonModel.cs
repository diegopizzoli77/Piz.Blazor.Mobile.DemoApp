using System.ComponentModel.DataAnnotations;

namespace Piz.Blazor.Mobile.DemoApp.MVVM.Model
{
    public class PersonModel
    {
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string Surname { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "BirthDay")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDay { get; set; }
    }
}
