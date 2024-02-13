using System.Windows;
using System.Windows.Controls;

namespace Surf_Settings_Window.CustomControls
{
    public partial class Button1 : UserControl
    {
        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register("ButtonText", typeof(string), typeof(Button1), new PropertyMetadata("Custom Button"));

        public static readonly DependencyProperty IconKindProperty =
            DependencyProperty.Register("IconKind", typeof(string), typeof(Button1), new PropertyMetadata(""));

        public static readonly DependencyProperty ShowIconProperty =
            DependencyProperty.Register("ShowIcon", typeof(bool), typeof(Button1), new PropertyMetadata(true));

        public static readonly DependencyProperty ButtonWidthProperty =
            DependencyProperty.Register("ButtonWidth", typeof(double), typeof(Button1), new PropertyMetadata(207.0));

        public static readonly DependencyProperty ButtonHeightProperty =
            DependencyProperty.Register("ButtonHeight", typeof(double), typeof(Button1), new PropertyMetadata(28.0));

        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        public string IconKind
        {
            get { return (string)GetValue(IconKindProperty); }
            set { SetValue(IconKindProperty, value); }
        }

        public bool ShowIcon
        {
            get { return (bool)GetValue(ShowIconProperty); }
            set { SetValue(ShowIconProperty, value); }
        }

        public double ButtonWidth
        {
            get { return (double)GetValue(ButtonWidthProperty); }
            set { SetValue(ButtonWidthProperty, value); }
        }

        public double ButtonHeight
        {
            get { return (double)GetValue(ButtonHeightProperty); }
            set { SetValue(ButtonHeightProperty, value); }
        }

        public Button1()
        {
            InitializeComponent();
            DataContext = this;

            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }
    }
}
