using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DateNightScenario
{
    /// <summary>
    /// Contains interaction logic for MainWindow.xaml.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Event handlers may begin with lower-case letters.")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.StyleCop.CSharp.MaintainabilityRules", "SA1401:FieldsMustBePrivate", Justification = "Encapsulation not yet taught.")]
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Harry is a pursuer in a date night scenario.
        /// </summary>
        public Pursuer Harry;

        /// <summary>
        /// Kayla is a pursuer in a date night scenario.
        /// </summary>
        public Pursuer Kayla;

        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Creates a pursuer named Harry and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newHarryAndSallyDateButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Pursuer class.
            this.Harry = new Pursuer();

            // Set field values of Harry.
            this.Harry.Age = 42;
            this.Harry.Friend = new Pursued();
            this.Harry.Hometown = new City();
            this.Harry.MoneyBalance = 200.00m;
            this.Harry.Name = "Harry";
            this.Harry.RomanceLevel = 50.0;
            this.Harry.Vehicle = new Car();

            // Set field values of Harry's pursued.
            this.Harry.Friend.Age = 38;
            this.Harry.Friend.Name = "Sally";
            this.Harry.Friend.RomanceLevel = 25.0;

            // Set field values of Harry's hometown.
            this.Harry.Hometown.CornerStore = new GasStation();
            this.Harry.Hometown.House1 = new House();
            this.Harry.Hometown.House2 = new House();
            this.Harry.Hometown.Name = "Chicago";
            this.Harry.Hometown.Salon = new HairSalon();
            this.Harry.Hometown.State = "IL";

            // Set field values of Harry's hometown's corner store.
            this.Harry.Hometown.CornerStore.Address = "105 Main Street";
            this.Harry.Hometown.CornerStore.Atm = new Atm();
            this.Harry.Hometown.CornerStore.GasPricePerGallon = 3.00m;
            this.Harry.Hometown.CornerStore.MoneyBalance = 586.00m;
            this.Harry.Hometown.CornerStore.Name = "Kwik Trip";

            // Set field values of the corner store's ATM.
            this.Harry.Hometown.CornerStore.Atm.CashAmount = 5000.00m;

            // Set field values of Harry's hometown's River Street house.
            this.Harry.Hometown.House1.Address = "120 River Street";
            this.Harry.Hometown.House1.Name = "Harry's House";

            // Set field values of Harry's hometown's Elm Street house.
            this.Harry.Hometown.House2.Address = "412 Elm Street";
            this.Harry.Hometown.House2.Name = "Sally's House";

            // Set field values of Harry's hair stylist.
            this.Harry.Hometown.Salon.Address = "132 Main Street";
            this.Harry.Hometown.Salon.MoneyBalance = 234.00m;
            this.Harry.Hometown.Salon.Name = "Floyd's Barbershop";
            this.Harry.Hometown.Salon.HaircutPrice = 5.00m;

            // Set field values of Harry's vehicle.
            this.Harry.Vehicle.Color = "Yellow";
            this.Harry.Vehicle.GasLevel = 10.0;
            this.Harry.Vehicle.LicenseNumber = "DMZ-873";
            this.Harry.Vehicle.Model = "Mustang";
            this.Harry.Vehicle.TankCapacity = 15.0;
            this.Harry.Vehicle.Year = 1969;

            // Harry buys a home and moves in.
            this.Harry.Home = this.Harry.Hometown.House1;
            this.Harry.Location = this.Harry.Home.Name;
            this.Harry.Home.IsOccupied = true;

            // Sally buys a home and moves in.
            this.Harry.Friend.Home = this.Harry.Hometown.House2;
            this.Harry.Friend.Location = this.Harry.Friend.Home.Name;
            this.Harry.Friend.Home.IsOccupied = true;
        }

        /// <summary>
        /// Creates a pursuer named Kayla and related objects.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void newKaylaAndRyanDateButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the Purser class.
            this.Kayla = new Pursuer();

            // Set field values of Kayla.
            this.Kayla.Age = 22;
            this.Kayla.Friend = new Pursued();
            this.Kayla.Hometown = new City();
            this.Kayla.MoneyBalance = 300.00m;
            this.Kayla.Name = "Kayla";
            this.Kayla.RomanceLevel = 40.0;
            this.Kayla.Vehicle = new Car();

            // Set field values of Kayla's pursued.
            this.Kayla.Friend.Age = 24;
            this.Kayla.Friend.Name = "Ryan";
            this.Kayla.Friend.RomanceLevel = 62.0;

            // Set field values of Kayla's hometown.
            this.Kayla.Hometown.CornerStore = new GasStation();
            this.Kayla.Hometown.House1 = new House();
            this.Kayla.Hometown.House2 = new House();
            this.Kayla.Hometown.Name = "Wausau";
            this.Kayla.Hometown.Salon = new HairSalon();
            this.Kayla.Hometown.State = "WI";

            // Set field values of Kayla's hometown's corner store.
            this.Kayla.Hometown.CornerStore.Address = "105 Main Street";
            this.Kayla.Hometown.CornerStore.Atm = new Atm();
            this.Kayla.Hometown.CornerStore.GasPricePerGallon = 3.00m;
            this.Kayla.Hometown.CornerStore.MoneyBalance = 322.00m;
            this.Kayla.Hometown.CornerStore.Name = "Kwik Trip";

            // Set field values of the corner store's ATM.
            this.Kayla.Hometown.CornerStore.Atm.CashAmount = 5000.00m;

            // Set field values of Kayla's hometown's River Street house.
            this.Kayla.Hometown.House1.Address = "222 River Street";
            this.Kayla.Hometown.House1.Name = "Kayla's House";

            // Set field values of Kayla's hometown's Elm Street house.
            this.Kayla.Hometown.House2.Address = "411 Elm Street";
            this.Kayla.Hometown.House2.Name = "Ryan's House";

            // Set field values of Kayla's hair stylist.
            this.Kayla.Hometown.Salon.Address = "134 Main Street";
            this.Kayla.Hometown.Salon.MoneyBalance = 432.00m;
            this.Kayla.Hometown.Salon.Name = "Sam's Salon";
            this.Kayla.Hometown.Salon.HaircutPrice = 9.00m;

            // Set field values of Kayla's vehicle.
            this.Kayla.Vehicle.Color = "Red";
            this.Kayla.Vehicle.GasLevel = 9.0;
            this.Kayla.Vehicle.LicenseNumber = "YYZ-983";
            this.Kayla.Vehicle.Model = "Camero";
            this.Kayla.Vehicle.TankCapacity = 12.0;
            this.Kayla.Vehicle.Year = 1963;

            // Kayla buys a home and moves in.
            this.Kayla.Home = this.Kayla.Hometown.House1;
            this.Kayla.Location = this.Kayla.Home.Name;
            this.Kayla.Home.IsOccupied = true;

            // Ryan buys a home and moves in.
            this.Kayla.Friend.Home = this.Kayla.Hometown.House2;
            this.Kayla.Friend.Location = this.Kayla.Friend.Home.Name;
            this.Kayla.Friend.Home.IsOccupied = true;
        }

        /// <summary>
        /// Harry prepares for his date.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void harryPrepareForDateButton_Click(object sender, RoutedEventArgs e)
        {
            this.Harry.PrepareForDate();
        }

        /// <summary>
        /// Kayla prepares for her date.
        /// </summary>
        /// <param name="sender">The object that initiated the event.</param>
        /// <param name="e">The event arguments for the event.</param>
        private void kaylaPrepareForDateButton_Click(object sender, RoutedEventArgs e)
        {
            this.Kayla.PrepareForDate();
        }
    }
}