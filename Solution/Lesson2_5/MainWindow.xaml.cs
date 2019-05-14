using Microsoft.Win32;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

/*
Расположите Toolbar в боковой части программы. Добавьте к нему свойство, дабы он располагался вертикально слева.

Добавьте еще один Toolbar и добавьте к нему текстовое поле. Расположите Toolbar в нижней части программы.
*/
namespace Lesson2_5
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

        private void ExitProgram_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void SaveFile_Click(object sender, RoutedEventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();
        }

        private void OpenNewFile_Click(object sender, RoutedEventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }

        private void TimesNewRomanFont_Click(object sender, RoutedEventArgs e) {
            textBox.FontFamily = new FontFamily("Times New Roman");
            verdanaFont.IsChecked = false;
        }

        private void VerdanaFont_Click(object sender, RoutedEventArgs e) {
            textBox.FontFamily = new FontFamily("Verdana");
            timesNewRomanFont.IsChecked = false;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            textBox.Background = Brushes.Red;
            Blue.IsChecked = false;
            Green.IsChecked = false;
        }

        private void Blue_Click(object sender, RoutedEventArgs e)
        {
            textBox.Background = Brushes.Blue;
            Red.IsChecked = false;
            Green.IsChecked = false;
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            textBox.Background = Brushes.Green;
            Red.IsChecked = false;
            Blue.IsChecked = false;
        }

        private void Black_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Black;
            White.IsChecked = false;
            Yellow.IsChecked = false;
        }

        private void White_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.White;
            Black.IsChecked = false;
            Yellow.IsChecked = false;
        }

        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Yellow;
            Black.IsChecked = false;
            White.IsChecked = false;
        }

        private void SelectFontSize_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string fontSize = selectFontSize.SelectedItem.ToString();
            fontSize = fontSize.Substring(fontSize.Length - 2);

            switch(fontSize) {
                case "10":
                    textBox.FontSize = 10;
                    break;
                case "14":
                    textBox.FontSize = 14;
                    break;
                case "16":
                    textBox.FontSize = 16;
                    break;
                case "20":
                    textBox.FontSize = 20;
                    break;
                case "24":
                    textBox.FontSize = 24;
                    break;
                case "32":
                    textBox.FontSize = 32;
                    break;
                case "48":
                    textBox.FontSize = 48;
                    break;
            }
        }
    }
}
