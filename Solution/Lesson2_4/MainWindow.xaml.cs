using Microsoft.Win32;
using System.Windows;
using System.Windows.Media;

/*
Добавьте дополнительный пункт в меню "Вид". Внутри него расположите вложенное меню: Фон редактора, Цвет текста.Цвет текста и фон будут меняться в зависимости от выбранного типа в меню.
*/
namespace Lesson2_4
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
    }
}
