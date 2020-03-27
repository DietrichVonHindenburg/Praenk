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

namespace Praenk
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //string s = "Ja, das bin ich.\rNaja, eigentlich nicht, aber aus irgendeinem Grund kann ich nichts anderes schreiben…\rAlso:\rJa, das bin ich.";
        string s = "Ja, das bin ich.";
        private bool isAllowedToClose = false;
        public MainWindow()
        {
            InitializeComponent();
            btn_submit.Content += " (Mindestlänge: " + s.Length + ")";
            btn_submit.IsEnabled = false;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!isAllowedToClose)
            {
                MessageBox.Show("Bitte beantworten Sie die Frage");
                e.Cancel = true;
            }
        }

        private void textbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            textbox.Text = s.Substring(0, Math.Min(s.Length, textbox.Text.Length));
            textbox.SelectionStart = textbox.Text.Length;

            if (textbox.Text.Length >= s.Length)
                btn_submit.IsEnabled = true;
            else
                btn_submit.IsEnabled = false;
        }

        private void btn_submit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("lololol XXD");
            isAllowedToClose = true;
            Close();
        }
    }
}
