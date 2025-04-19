using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class UsersPage : Page
    {
        public UsersPage()
        {
            InitializeComponent();
            LoadUsers();
        }

        private void LoadUsers()
        {
            using (var context = new Entities1())
            {
                UsersGrid.ItemsSource = context.Users.ToList();
            }
        }
    }
}
