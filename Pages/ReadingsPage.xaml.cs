using System.Windows.Controls;
using System.Linq;


namespace ЖКХ.Pages
{
    public partial class ReadingsPage : Page
    {
        public ReadingsPage()
        {
            InitializeComponent();
            LoadReadings();
        }

        private void LoadReadings()
        {
            using (var context = new Entities1())
            {
                ReadingsGrid.ItemsSource = context.Readings.ToList();
            }
        }
    }
}
