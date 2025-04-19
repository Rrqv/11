using System.Windows;
using System.Windows.Controls;
using ЖКХ.Pages;

namespace ЖКХ
{
    public partial class ResidentPage : Page
    {
        private User currentUser;

        public ResidentPage(User user)
        {
            InitializeComponent();
            currentUser = user;
            Title = $"Жилец: {currentUser.Username}";
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AuthorizationPage());
        }

        private void Payments_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ResidentPaymentsPage(currentUser));
        }

        private void Meters_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ResidentMetersPage(currentUser));
        }

        private void Readings_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ResidentReadingsPage(currentUser));
        }

        private void Requests_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ResidentRequestsPage(currentUser));
        }
    }
}
