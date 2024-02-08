using System.Windows;
using System.Windows.Controls;

namespace Surf_Settings_Window.CustomControls
{
    public partial class Button1 : UserControl
    {
        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register("ButtonText", typeof(string), typeof(Button1), new PropertyMetadata("Custom Button"));


        public string ButtonText
        {
            get { return (string)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }


        public Button1()
        {
            InitializeComponent();
            DataContext = this; // Set UserControl's DataContext to itself for binding to work properly
        }
    }
}
