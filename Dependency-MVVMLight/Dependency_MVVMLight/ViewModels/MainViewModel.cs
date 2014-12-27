using Dependency_MVVMLight.Services;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace Dependency_MVVMLight.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly IPopupService _popupService;

        public MainViewModel(IPopupService popupService)
        {
            _popupService = popupService;
        }


        private RelayCommand _showMessageCommand;

        public RelayCommand ShowMessageCommand
        {
            get
            {
                if (_showMessageCommand == null)
                {
                    _showMessageCommand = new RelayCommand(() =>
                    {
                        _popupService.ShowPopup("Sample title", "Sample message");
                    });
                }

                return _showMessageCommand;
            }
        }
    }
}
