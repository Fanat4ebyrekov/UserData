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
using System.IO;
using System.Text.RegularExpressions;

namespace NikitaNikita23
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = @"C:\C:\Users\WSR\Desktop\note.txt";

        List<list> peopleList = new List<list>();
        public MainWindow()
        {
            InitializeComponent();

            peopleList.Add(new list
            { Age = 18, LName = "Симонов", Id = 1, Name = "Никита" });
            peopleList.Add(new list
            { Age = 12, LName = "Воробьев", Id = 2, Name = "Кирилл" });
            peopleList.Add(new list
            { Age = 13, LName = "Усачев", Id = 3, Name = "Александер" });
            peopleList.Add(new list
            { Age = 17, LName = "Римский", Id = 4, Name = "Алексей" });
            peopleList.Add(new list
            { Age = 54, LName = "Незруков", Id = 5, Name = "Бикита" });

            

        }

        

        private void txBName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void txBLName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void txBAge_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int val;
            if (!int.TryParse(e.Text, out val))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\WSR\Desktop\note.txt";

            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.Write(txBName.Text);
                sw.Write(";");
                sw.Write(txBLName.Text);
                sw.Write(";");
                sw.Write(txBAge.Text);
                sw.WriteLine();
                sw.Close();
            }

            MessageBox.Show($"Имя {txBName.Text}  Фамилия {txBLName.Text}  Возраст {txBAge.Text}");
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            
            Blocknot blc = new Blocknot();
            this.Hide();
            blc.ShowDialog();
            this.Show();
        }

        private void txBName_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void txBLName_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void txBAge_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void txBName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.A) || (e.Key > Key.Z))
                e.Handled = true;
        }

        private void txBLName_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.A) || (e.Key > Key.Z))
                e.Handled = true;
        }
    }
}
