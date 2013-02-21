using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;


namespace MiniBrowser
{
    public partial class MainPage : PhoneApplicationPage
    {
        PhoneCallTask phoneTask = null;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            phoneTask = new PhoneCallTask(); 
        }

        private void makeCall_Click(object sender, RoutedEventArgs e)
        {
            phoneTask.DisplayName = "Liisa";
            phoneTask.PhoneNumber = "+358408255902"; // put your desired phone number here
            phoneTask.Show();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

            //ResultsLabel.Text = "results are loading...";
            //ResultsData.DataContext = null;

            //Contacts cons = new Contacts();

            //cons.SearchCompleted += new EventHandler<ContactsSearchEventArgs>(Contacts_SearchCompleted);

            //cons.SearchAsync(contactFilterString.Text, contactFilterKind, "Contacts Test #1");
        }
    }
}