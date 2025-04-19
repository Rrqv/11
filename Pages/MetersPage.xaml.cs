using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class MetersPage : Page
    {
        public MetersPage()
        {
            InitializeComponent();
            LoadMeters();
        }

        private void LoadMeters()
        {
            using (var context = new Entities1())
            {
                MetersGrid.ItemsSource = context.Meters.ToList();
            }
        }
    }
}
