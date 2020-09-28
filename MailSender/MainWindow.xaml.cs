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
using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Net.Mail;

namespace MailSender
{

    public static class SmtpDefaultAdress
    {
        static string SmtpAdress = "smtp.yandex.ru";
        static int SmtpPort = 25;
    }

    public class EmailSendServiceClass
    {
        public void SendEmail(MailMessage Message, string SmtpAdress, int SmtpPort, string Login, string Password)
        {
            SmtpClient smtp = new SmtpClient(SmtpAdress, SmtpPort);
            smtp.Credentials = new NetworkCredential(Login, Password);
            smtp.EnableSsl = true;
            smtp.Send(Message);
        }
    }


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //SendEndWindow sew = new SendEndWindow();
            //sew.ShowDialog();

            tabControl.SelectedItem = tabPlanner;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ErrWindow sew = new ErrWindow();
            sew.lblText.Content = "Невероятная ошибка";
            sew.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (TextBox.Text == "")
            {
                ErrWindow sew = new ErrWindow();
                sew.lblText.Content = "Письмо не заполнено";
                sew.ShowDialog();
            }
        }
    }
}
