/*
 * Author: Israel B. Lopez De Jesus
 * Class: OrderSummaryControl.xaml.cs
 * Purpose: The logic behing the user interface OrderSummary.xaml
 */

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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;

using PointOfSale.ExtensionMethods;
using PointOfSale.CustomizationScreens;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        private void DeleteItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is Button)
                {
                    IOrderItem item = ((sender as ListBox).SelectedItem as IOrderItem);
                    FrameworkElement screen = null;
                    var orderControl = this.FindAncestor<OrderControl>();

                    //Cast sender to button
                    Button b = (Button)sender;

                }
            }
        }

        private void PreviousItemSelection(object sender, SelectionChangedEventArgs e)
        {
            if (DataContext is Order data)
            {
                if (sender is ListBox)
                {
                    IOrderItem item = ((sender as ListBox).SelectedItem as IOrderItem);
                    FrameworkElement screen = null;
                    var orderControl = this.FindAncestor<OrderControl>();

                    //Cast sender to button
                    ListBox b = (ListBox)sender;
                    string text = item.ToString();
                    //Filter which button was pressed based on name
                    switch (text)
                    {
                        case "Angry Chicken":
                            screen = new AngryChickenCustomization(DataContext);
                            break;
                        case "Cowpoke Chili":
                            screen = new CowpokeChiliCustomization(DataContext);
                            break;
                        case "Dakota Double Burger":
                            screen = new DakotaDoubleCustomization(DataContext);
                            break;
                        case "Pecos Pulled Pork":
                            screen = new PecosPulledPorkCustomization(DataContext);
                            break;
                        case "Rustler's Ribs":
                            screen = new RustlersRibsCustomization();
                            break;
                        case "Texas Triple Burger":
                            screen = new TexasTripleCustomization(DataContext);
                            break;
                        case "Trail Burger":
                            screen = new TrailBurgerCustomization(DataContext);
                            break;
                        case "Small Baked Beans":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Madium Baked Beans":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Large Baked Beans":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Small Chili Cheese Fries":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Medium Chili Cheese Fries":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Large Chili Cheese Fries":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Small Corn Dodgers":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Medium Corn Dodgers":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Large Corn Dodgers":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Small Pan De Campo":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Medium Pan De Campo":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Large Pan De Campo":
                            screen = new SideSizeCustomization(DataContext);
                            break;
                        case "Small Cowboy Coffee":
                            screen = new CowboyCoffeeCustomization(DataContext);
                            break;
                        case "Medium Cowboy Coffee":
                            screen = new CowboyCoffeeCustomization(DataContext);
                            break;
                        case "Large Cowboy Coffee":
                            screen = new CowboyCoffeeCustomization(DataContext);
                            break;
                        case "Small Decaf Cowboy Coffee":
                            screen = new CowboyCoffeeCustomization(DataContext);
                            break;
                        case "Medium Decaf Cowboy Coffee":
                            screen = new CowboyCoffeeCustomization(DataContext);
                            break;
                        case "Large Decaf Cowboy Coffee":
                            screen = new CowboyCoffeeCustomization(DataContext);
                            break;
                        case "Small Jerked Soda":
                            screen = new JerkedSodaCustomization(DataContext);
                            break;
                        case "Medium Jerked Soda":
                            screen = new JerkedSodaCustomization(DataContext);
                            break;
                        case "Large Jerked Soda":
                            screen = new JerkedSodaCustomization(DataContext);
                            break;
                        case "Small Texas Tea":
                            screen = new TexasTeaCustomization(DataContext);
                            break;
                        case "Medium Texas Tea":
                            screen = new TexasTeaCustomization(DataContext);
                            break;
                        case "Large Texas Tea":
                            screen = new TexasTeaCustomization(DataContext);
                            break;
                        case "Small Water":
                            screen = new WaterCustomization(DataContext);
                            break;
                        case "Medium Water":
                            screen = new WaterCustomization(DataContext);
                            break;
                        case "Large Water":
                            screen = new WaterCustomization(DataContext);
                            break;
                        default:
                            throw new NotImplementedException("Unknown button clicked");
                    }
                    if (screen != null) screen.DataContext = item;
                    orderControl?.SwapScreen(screen);
                }
            }
        }
    }
}