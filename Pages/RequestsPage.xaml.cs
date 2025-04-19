using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class RequestsPage : Page
    {
        public RequestsPage()
        {
            InitializeComponent();
            LoadRequests();
        }

        private void LoadRequests()
        {
            using (var context = new Entities1())
            {
                RequestsGrid.ItemsSource = context.Requests.ToList();
            }
        }
    }
}
