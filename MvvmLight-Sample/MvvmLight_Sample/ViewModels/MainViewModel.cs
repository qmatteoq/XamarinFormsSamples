using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace MvvmLight_Sample.ViewModels
{
    public class MainViewModel: ViewModelBase
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                Set(ref _name, value);
                ShowMessageCommand.RaiseCanExecuteChanged();
            }
        }

        private string _message;

        public string Message
        {
            get { return _message;}
            set { Set(ref _message, value); }
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
                        Message = string.Format("Hello {0}", Name);
                    }, () => !string.IsNullOrEmpty(Name));
                }

                return _showMessageCommand;
            }
        }
    }
}
