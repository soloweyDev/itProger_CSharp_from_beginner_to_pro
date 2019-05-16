using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lesson2_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //this.Title = "Hello To All";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e) {
            saveToFile();
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();

            bool? res = ofd.ShowDialog();

            if (res != false) {
                Stream myStream;
                if ((myStream = ofd.OpenFile()) != null) {
                    string file_name = ofd.FileName;
                    string file_text = File.ReadAllText(file_name);
                    textBox.Text = file_text;
                }
            }
        }

        private void saveToFile() {
            SaveFileDialog sfd = new SaveFileDialog();
            bool? res = sfd.ShowDialog();

            if (res != false) {
                using (Stream s = File.Open(sfd.FileName, FileMode.OpenOrCreate)) {
                    using (StreamWriter sw = new StreamWriter(s)) {
                        sw.Write(textBox.Text);
                    }
                }
            }
        }
    }
}
