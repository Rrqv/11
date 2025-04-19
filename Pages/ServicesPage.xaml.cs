using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
            LoadServices();
        }

        private void LoadServices()
        {
            using (var context = new Entities1())
            {
                ServicesGrid.ItemsSource = context.Services.ToList();
            }
        }
    }
}
