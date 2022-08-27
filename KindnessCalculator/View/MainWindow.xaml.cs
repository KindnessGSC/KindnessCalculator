using System.Windows;

namespace KindnessCalculator.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new Model.ButtonHandler(Layout.Children);
        }
    }
}
