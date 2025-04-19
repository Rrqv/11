using System.Windows.Controls;
using System.Linq;

namespace ЖКХ.Pages
{
    public partial class PaymentsPage : Page
    {
        public PaymentsPage()
        {
            InitializeComponent();
            LoadPayments();
        }

        private void LoadPayments()
        {
            using (var context = new Entities1())
            {
                PaymentsGrid.ItemsSource = context.Payments.ToList();
            }
        }
    }
}
