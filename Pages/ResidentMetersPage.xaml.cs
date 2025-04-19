using System.Linq;
using System.Windows.Controls;

namespace ЖКХ.Pages
{
    public partial class ResidentMetersPage : Page
    {
        private User _currentUser;

        public ResidentMetersPage(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            LoadMeters();
        }

        private void LoadMeters()
        {
            using (var context = new Entities1())
            {
                ResidentMetersGrid.ItemsSource = context.Meters.Where(m => m.UserId == _currentUser.Id).ToList();
            }
        }
    }
}
