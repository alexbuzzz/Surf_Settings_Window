using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace Surf_Settings_Window.CustomControls
{
    public partial class ComboBox : UserControl
    {
        public static readonly DependencyProperty ComboBoxWidthProperty =
            DependencyProperty.Register("ComboBoxWidth", typeof(double), typeof(ComboBox), new PropertyMetadata(120.0));

        public static readonly DependencyProperty ComboBoxHeightProperty =
            DependencyProperty.Register("ComboBoxHeight", typeof(double), typeof(ComboBox), new PropertyMetadata(42.0));

        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<ComboBoxItem>), typeof(ComboBox), new PropertyMetadata(null));

        public double ComboBoxWidth
        {
            get { return (double)GetValue(ComboBoxWidthProperty); }
            set { SetValue(ComboBoxWidthProperty, value); }
        }

        public double ComboBoxHeight
        {
            get { return (double)GetValue(ComboBoxHeightProperty); }
            set { SetValue(ComboBoxHeightProperty, value); }
        }

        public ObservableCollection<ComboBoxItem> ItemsSource
        {
            get { return (ObservableCollection<ComboBoxItem>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        public ComboBox()
        {
            InitializeComponent();
            DataContext = this;

            ItemsSource = new ObservableCollection<ComboBoxItem>();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
