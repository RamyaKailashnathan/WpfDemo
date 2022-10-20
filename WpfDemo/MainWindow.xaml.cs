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
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            InitializeComponent();
        }
        //Property Trigger functionality display
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Forms.MainForm fr = new Forms.MainForm();
            fr.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        
        // Event Trigger Functionality display-MouseEnter and MouseLeave
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Forms.EventTrigger et = new Forms.EventTrigger();
            et.Show();
        }
        // Data Trigger Functionality-Checkbox check
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Forms.DataTrigger dt = new Forms.DataTrigger();
            dt.Show();
        }
        //Exit funcationality
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
