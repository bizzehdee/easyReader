using Avalonia.Controls;
using Avalonia.ReactiveUI;
using easyReader.ViewModels;
using ReactiveUI;
using System.Threading.Tasks;

namespace easyReader.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}