using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class CompaniesPage : Page
    {
        public CompaniesPage()
        {
            InitializeComponent();
            LoadCompanies();
        }

        private void LoadCompanies()
        {
            using (var context = new Entities1())
            {
                CompaniesGrid.ItemsSource = context.ManagementCompanies.ToList();
            }
        }
    }
}
