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
using Microsoft.Win32;
using System.IO;


namespace EcommerceHomework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User us = new User();

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void Drop_down_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            us.Name = Username_textbox.Text;
            us.Password = PasswordBox.Password;
            //us.Age = DateTime.Now.Year - Date.SelectedDate.Value.Year;
            //MessageBox.Show(Date.SelectedDate.Value.Year.ToString());
            us.PhoneNumber = PhoneNumberInput.Text;
            us.Sex = Drop_down_list.Text;
            us.Email = EmailInput.Text;
            if (Emailchecklist.IsChecked == true)
            {
                us.GDPR1[0] = "Email";
            }
            if (Mail.IsChecked == true)
            {
                us.GDPR1[1] = "Mail";
            }
            if (Phonecall.IsChecked == true)
            {
                us.GDPR1[2] = "Phone call";
            }
            if (SMS.IsChecked == true)
            {
                us.GDPR1[3] = "SMS";
            }
            if (yes.IsChecked == true)
            {
                us.newsletter = "yes";
            }
            if (no.IsChecked == true)
            {
                us.newsletter = "no";
            }
            

            us.PicturePath = imageFile.Source.ToString();
            //MessageBox.Show(imageFile.Source.ToString());
            Validation();
            us.saveData();
        }

        private void View_Click(object sender, RoutedEventArgs e)
        {
            //User mc = new User();
            MessageBoxResult mbr = MessageBox.Show("Please enter your username");
            string userName = mbr.ToString();
            MessageBox.Show(userName);
            //string[] sw = File.ReadAllLines("UserData.txt");
            //string[] str = sw[0].Split(',');
            //Username_textbox.Text = str[0];
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked_2(object sender, RoutedEventArgs e)
        {

        }

        private void Select_Image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select an image from your computer";
            ofd.Filter = "All supported images |*.jpeg;*.jpg;*.png;";
            if (ofd.ShowDialog() == true)
            {
                imageFile.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }

        private void PhoneNumberInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public void Validation()
        {
            if (Username_textbox.Text == string.Empty)
            {
                MessageBox.Show("Please enter username");
            }
            if (PasswordBox.Password == string.Empty)
            {
                MessageBox.Show("Please enter password");
            }
            if (PhoneNumberInput.Text == string.Empty)
            {
                MessageBox.Show("Please enter phone number");
            }
            if (Drop_down_list.Text == string.Empty)
            {
                MessageBox.Show("Please enter gender");
            }
            //if ( == string.Empty)
            //{
            //    MessageBox.Show("Please enter ");
            //}

        }
    }

}
