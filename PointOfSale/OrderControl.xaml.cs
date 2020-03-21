using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CowboyCafe.Data;
//using system.ComponentModel;
namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// In here the buttons for adding the entrie will be called. 
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            AddCowpokeChilliButton.Click += OnAddCowpokeChilliButtonClick;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClick;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClick;
            AddCornDogersButton.Click += OnAddCornDodgersButtonClick;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClick;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClick;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClick;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClick;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClick;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClick;
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClick;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClick;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClick;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClick;
            AddWaterButton.Click += OnAddWaterButtonClick;
        }

        /// <summary>
        /// These are all the methods that will add to the order the entries when clicked on the screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnAddCowpokeChilliButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }
        void OnAddTrailBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }
        void OnAddAngryChickenButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }
        void OnAddDakotaDoubleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }
        void OnAddRustlersRibsButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }
        void OnAddPecosPulledPorkButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }
        void OnAddTexasTripleBurgerButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }
        void OnAddPanDeCampoButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }
        void OnAddBakedBeansButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }
        void OnAddCornDodgersButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }
        void OnAddChiliCheeseFriesButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChiliCheeseFries());
        }
        void OnAddJerkedSodaButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }
        void OnAddWaterButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
        void OnAddTexasTeaButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }
        void OnAddCowboyCoffeeButtonClick(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }
    }
}
