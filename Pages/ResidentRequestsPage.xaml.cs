using System.Linq;
using System.Windows.Controls;

namespace ЖКХ.Pages
{
    public partial class ResidentRequestsPage : Page
    {
        private User _currentUser;

        public ResidentRequestsPage(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            LoadRequests();
        }

        private void LoadRequests()
        {
            using (var context = new Entities1())
            {
                ResidentRequestsGrid.ItemsSource = context.Requests.Where(r => r.UserId == _currentUser.Id).ToList();
            }
        }
    }
}
