using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
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
using ApiApp.Controllers.JSON;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;

namespace DesktopApp
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

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            HttpClient client = new HttpClient();

            LoginJSON loginJSON = new LoginJSON
            {
                login = loginTextBox.Text,
                password = passwordPasswordBox.Password
            };

            StringContent content = new StringContent(JsonConvert.SerializeObject(loginJSON), Encoding.UTF8, "application/json");

            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Post, "http://192.168.25.39:5075/login");
            httpRequestMessage.Headers.Add("Accept", "application/json");

            httpRequestMessage.Content = content;

            var response = client.SendAsync(httpRequestMessage).Result;

            if((int)response.StatusCode == 200)
            {
                MessageBox.Show("ok");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
