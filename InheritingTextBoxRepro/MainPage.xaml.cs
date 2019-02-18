using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace InheritingTextBoxRepro
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            DataContext = new MainPageViewModel();
        }
    }

    public sealed class MainPageViewModel : INotifyPropertyChanged
    {
        private int _quantity1;
        private int _quantity2;
        public int Quantity1
        {
            get => _quantity1;
            set
            {
                _quantity1 = value;
                OnPropertyChanged(nameof(Quantity1));
            }
        }
        public int Quantity2
        {
            get => _quantity2;
            set
            {
                _quantity2 = value;
                OnPropertyChanged(nameof(Quantity2));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
