using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DesignPattern;

namespace DesignPattern
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            comboBox.ItemsSource = ThemeList;

            this.comboBox.SelectionChanged += new SelectionChangedEventHandler(comboBox_SelectionChanged);
           
        }

        public void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    	{
	        var comboBox = sender as ComboBox;
	        string value = comboBox.SelectedItem as string;

            if (value == "Red")
            {
                IWidgetFactory RedTheme = new RedTheme();
                button.Background = new BrushConverter().ConvertFromString(RedTheme.ThemeLoad()) as SolidColorBrush;

            }
            else if(value == "Cyan")
            {
                IWidgetFactory BlueTheme = new BlueTheme();
                button.Background = new BrushConverter().ConvertFromString(BlueTheme.ThemeLoad()) as SolidColorBrush;

            }

        }


        public List<string> ThemeList = new List<string> { "Red", "Cyan" };
    }
}
