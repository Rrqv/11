using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class ResidentsPage : Page
    {
        public ResidentsPage()
        {
            InitializeComponent();
            LoadResidents();
        }

        private void LoadResidents()
        {
            using (var context = new Entities1())
            {
                ResidentsGrid.ItemsSource = context.Residents.ToList();
            }
        }
    }
}
