using System.Windows;
using System.Windows.Controls;

namespace LE_Builder_Sharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FrameworkElement_OnLoaded(object sender, RoutedEventArgs e)
        {
            var toolBar = sender as ToolBar;
            if (toolBar.Template.FindName("OverflowGrid", toolBar) is FrameworkElement overflowGrid)
                overflowGrid.Visibility = Visibility.Collapsed;

            if (toolBar.Template.FindName("MainPanelBorder", toolBar) is FrameworkElement mainPanelBorder)
                mainPanelBorder.Margin = new Thickness();
        }

        private void On_ConnectToPlc(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Not implemented yet!", "Sorry!", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}