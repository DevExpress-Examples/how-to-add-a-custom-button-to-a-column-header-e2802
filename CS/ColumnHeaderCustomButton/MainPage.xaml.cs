using System.Windows;
using System.Windows.Controls;

namespace ColumnHeaderCustomButton {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            // Process mouse clicks.
        }
    }
}
