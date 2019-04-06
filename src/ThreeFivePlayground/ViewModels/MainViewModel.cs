using System.Windows.Input;
using ThreeFivePlayground.ViewModels.Base;
using Xamarin.Forms;

namespace ThreeFivePlayground.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand BindableLayoutCommand => new Command(ExecuteBindableLayout);
        public ICommand ScrollBarVisibilityCommand => new Command(ExecuteScrollBarVisibility);
        public ICommand SwitchCellOnColorCommand => new Command(ExecuteSwitchCellOnColor);

        void ExecuteBindableLayout()
        {
            NavigationService.NavigateToAsync<BindableLayoutViewModel>();
        }

        void ExecuteScrollBarVisibility()
        {
            NavigationService.NavigateToAsync<ScrollBarVisibilityViewModel>();
        }

        void ExecuteSwitchCellOnColor()
        {
            NavigationService.NavigateToAsync<SwitchCellOnColorViewModel>();
        }
    }
}
