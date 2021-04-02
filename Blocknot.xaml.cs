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
using System.Windows.Shapes;
using System.IO;

namespace NikitaNikita23
{
    /// <summary>
    /// Логика взаимодействия для Blocknot.xaml
    /// </summary>
    public partial class Blocknot : Window
    {
        public Blocknot()
        {
            InitializeComponent();
            List<list> lists = new List<list>();
            string path = @"C:\Users\WSR\Desktop\note.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < File.ReadLines(path).Count(); i++)
                {
                    string str = sr.ReadLine();



                    if (str.ToString().Length > 7)
                    {
                        Console.WriteLine(str);
                        string[] user = str.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries );
                        lists.Add(new list
                        {
                            Name = user[0],
                            LName = user[1],
                            Age = Int32.Parse(user [2]),
                            Id=1+i
                            
                        });

                    }
                }
            }
            dataUser.ItemsSource = lists;
        }

        private void ButtonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
