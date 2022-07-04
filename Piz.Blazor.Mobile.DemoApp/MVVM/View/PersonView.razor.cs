using Microsoft.AspNetCore.Components;
using Piz.Blazor.Mobile.DemoApp.MVVM.ViewModel;

namespace Piz.Blazor.Mobile.DemoApp.MVVM.View
{
    public partial class PersonView
    {
        [Parameter]
        public IPersonViewModel PViewModel { get; set; }

        protected override void OnInitialized()
        {
            PViewModel.Load();
            base.OnInitialized();
        }
    }
}
