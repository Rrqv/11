using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class BuildingsPage : Page
    {
        public BuildingsPage()
        {
            InitializeComponent();
            LoadBuildings();
        }

        private void LoadBuildings()
        {
            using (var context = new Entities1())
            {
                BuildingsGrid.ItemsSource = context.Buildings.ToList();
            }
        }
    }
}
