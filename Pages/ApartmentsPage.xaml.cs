using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class ApartmentsPage : Page
    {
        public ApartmentsPage()
        {
            InitializeComponent();
            LoadApartments();
        }

        private void LoadApartments()
        {
            using (var context = new Entities1())
            {
                ApartmentsGrid.ItemsSource = context.Apartments.ToList();
            }
        }
    }
}
