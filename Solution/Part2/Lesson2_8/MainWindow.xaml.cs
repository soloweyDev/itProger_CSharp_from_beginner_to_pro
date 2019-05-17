using Microsoft.Win32;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Lesson2_8
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
            saveToFile();
        }

        private void OpenNewFile_Click(object sender, RoutedEventArgs e) {
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

        private void TimesNewRomanFont_Click(object sender, RoutedEventArgs e) {
            textBox.FontFamily = new FontFamily("Times New Roman");
            verdanaFont.IsChecked = false;
        }

        private void VerdanaFont_Click(object sender, RoutedEventArgs e) {
            textBox.FontFamily = new FontFamily("Verdana");
            timesNewRomanFont.IsChecked = false;
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

        private void CreateNewFile_Click(object sender, RoutedEventArgs e) {
            if(textBox.Text != "") {
                saveToFile();
            }
            textBox.Text = "";
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

        private void RegBtn_Click(object sender, RoutedEventArgs e) {
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            SqlConnection sql = new SqlConnection(connectionString);

            try {
                if (sql.State == System.Data.ConnectionState.Closed)
                    sql.Open();

                string query = "SELECT COUNT(1) FROM Users WHERE login=@login AND password=@pass";
                SqlCommand sqlCom = new SqlCommand(query, sql);
                sqlCom.CommandType = System.Data.CommandType.Text;
                sqlCom.Parameters.Add("@login", loginField.Text);
                sqlCom.Parameters.Add("@pass", passField.Password);

                int countUser = Convert.ToInt32(sqlCom.ExecuteScalar());
                if(countUser == 0) {
                    query = "INSERT INTO Users(login, password) VALUES(@login, @pass)";
                    SqlCommand com = new SqlCommand(query, sql);
                    com.CommandType = System.Data.CommandType.Text;
                    com.Parameters.Add("@login", loginField.Text);
                    com.Parameters.Add("@pass", passField.Password);

                    com.ExecuteNonQuery();
                    MessageBox.Show("Мы добавили вас в базу данных!");
                } else {
                    MessageBox.Show("Вы успешно авторизовались!");
                    AuthPage authPage = new AuthPage();
                    authPage.Show();

                    App.Current.MainWindow.Hide();
                }

            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                sql.Close();
            }
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.AppSettings["connectionString"];

            SqlConnection sql = new SqlConnection(connectionString);

            try
            {
                if (sql.State == System.Data.ConnectionState.Closed)
                    sql.Open();

                string query = "DELETE FROM Users WHERE login=@login AND password=@pass";
                SqlCommand sqlCom = new SqlCommand(query, sql);
                sqlCom.CommandType = System.Data.CommandType.Text;
                sqlCom.Parameters.Add("@login", loginField.Text);
                sqlCom.Parameters.Add("@pass", passField.Password);
                sqlCom.ExecuteNonQuery();

                MessageBox.Show("Пользователь удален!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.Close();
            }
        }
    }
}
