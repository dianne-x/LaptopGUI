using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace LaptopGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Laptop> laptops = new List<Laptop>();
        int viewedlaptops = 0;
        public MainWindow()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(@"C:\Users\Ny19BobákK\source\repos\LaptopGUI\SRC\laptops.txt"))
            {
                _ = sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    laptops.Add(new Laptop(sr.ReadLine()));
                }
            }

            var manufcturerCount = laptops.GroupBy(l => l.Manufacturer.ManufacturerName).Count();
            var amountCount = laptops.Count;

            mainTextLbl.Content = $" Válasszon {manufcturerCount} gyártó {amountCount} laptopja közül!";
            mainTextLbl.FontWeight = FontWeights.Bold;


            for (int i = 0; i < laptops.Count; i++)
            {
                laptopsListBox.Items.Add($"{i + 1} {laptops[i].ToString()}");
            }
        }

        private void laptopsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewedlaptops++;
            detailsListBox.Items.Clear();
            var selectedLaptop = laptops[laptopsListBox.SelectedIndex];
            var screenParts = selectedLaptop.Screen.Split(new[] { " - " }, StringSplitOptions.None);
            var kepatlo = screenParts[0].Trim(); 
            var felbontas = screenParts[1].Trim(); 
            detailsListBox.Items.Add(
                $"Kategória\n\t{selectedLaptop.Category}\n" +
                $"Képátló\n\t{kepatlo}\n" +
                $"Felbontás\n\t{felbontas}\n" +
                $"Processzor\n\t{selectedLaptop.CPU}\n" +
                $"RAM\n\t{selectedLaptop.RAM} GB\n" +
                $"Háttértár(ak)\n\t{selectedLaptop.Storage}" +
                $"Operációs rendszer\n\t{selectedLaptop.OS}\n" +
                $"Ár\n\t{selectedLaptop.Price} Ft\n"
                );
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Ön {viewedlaptops} termékünket tekintette meg. Visszavárjuk!");
            Close();
        }
    }
}