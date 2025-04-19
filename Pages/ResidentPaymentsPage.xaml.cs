using System.Linq;
using System.Windows.Controls;

namespace ЖКХ.Pages
{
    public partial class ResidentPaymentsPage : Page
    {
        private User _currentUser;

        public ResidentPaymentsPage(User currentUser)
        {
            InitializeComponent();
            _currentUser = currentUser;
            LoadPayments();
        }

        private void LoadPayments()
        {
            using (var context = new Entities1())
            {
                ResidentPaymentsGrid.ItemsSource = context.Payments.Where(p => p.UserId == _currentUser.Id).ToList();
            }
        }
    }
}
