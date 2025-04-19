using System.Threading;
using System.Windows;
using System.Windows.Controls;
using ЖКХ.Pages;

namespace ЖКХ
{
    public partial class AdminPage : Page
    {
        private User currentUser;

        public AdminPage(User user)
        {
            InitializeComponent();
            currentUser = user;
            Title = $"Администратор: {currentUser.Username}";
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new AuthorizationPage());
        }

        private void Users_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new UsersPage());
        }

        private void Residents_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ResidentsPage());
        }

        private void Apartments_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ApartmentsPage());
        }

        private void Buildings_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new BuildingsPage());
        }

        private void Companies_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new CompaniesPage());
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ServicesPage());
        }

        private void Payments_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new PaymentsPage());
        }

        private void Meters_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new MetersPage());
        }

        private void Readings_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new ReadingsPage());
        }

        private void Requests_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new RequestsPage());
        }
    }
}
