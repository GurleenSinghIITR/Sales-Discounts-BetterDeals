using System;
using System.Windows;


namespace MSOffice_Sales_Discount_Group2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal fixedCost = 99;     /// We have iniltialized every variable as decimal for sake of simplicity
        decimal result;         
        decimal discount;
        decimal total;
        decimal d1 = 0.80m;
        decimal d2 = 0.70m;
        decimal d3 = 0.60m;
        decimal d4 = 0.50m;
        decimal d0 = 0.00m;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoIt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal quantity = Decimal.Parse(inputText.Text);

                if (quantity % 1 != 0 || quantity <= 0)
                {
                    showMe.Content = "You can't buy fractional/negative packages.";
                }
                else
                {
                    if (quantity < 10)   ///"No discount" range
                    {
                        result = quantity * fixedCost * (1 - d0);
                        discount = quantity * fixedCost * d0;
                        showMe.Content = "Total Price= $" + result + "\rDiscount   = $" + discount;
                    }
                    else if (quantity <= 17)    ///First discount range
                    {
                        total = quantity * fixedCost;
                        result = quantity * fixedCost * d1;
                        discount = total - result;
                        showDiscount.Content = "You are Availing 20% discount";
                        showMe.Content = "Total Price= $" + result + "\rDiscount   = $" + discount + "total is " + total;
                    }
                    else if (quantity <= 19)
                    {
                        int counter1 = 20;
                        while (quantity * fixedCost * d1 > fixedCost * counter1 * d2)   ///better deal
                        {
                            counter1++;
                        }
                        result = quantity * fixedCost * d1;
                        discount = quantity * fixedCost * (1 - d1);
                        showDiscount.Content = "You are Availing 20% discount";
                        showMe.Content = "Total Price= $" + result + "\rDiscount   = $" + discount + "\rBuy " + (counter1 - quantity) + " more packages for a better deal by spending a LITTLE MORE.";
                    }
                    else if (quantity <= 42)    ///second discount range
                    {
                        result = quantity * fixedCost * d2;
                        discount = quantity * fixedCost * (1 - d2);
                        showMe.Content = "Total Price= $" + result + "\rDiscount   = $" + discount;
                        showDiscount.Content = "You are Availing 30% discount";
                    }
                    else if (quantity <= 49)
                    {
                        int counter2 = 50;
                        while (quantity * fixedCost * d2 > fixedCost * counter2 * d3)   ///better deal
                        {
                            counter2++;
                        }
                        result = quantity * fixedCost * d2;
                        discount = quantity * fixedCost * (1 - d2);
                        showMe.Content = "Total Price= $" + result + "\rDiscount   = $" + discount + "\rBuy " + (counter2 - quantity) + " more packages for a better deal by spending a LITTLE MORE.";
                        showDiscount.Content = "You are Availing 30% discount";
                    }
                    else if (quantity <= 83)   ///third discount range
                    {
                        result = quantity * fixedCost * d3;
                        discount = quantity * fixedCost * (1 - d3);
                        showMe.Content = "Total Price= $" + result + "\rDiscount   = $" + discount;
                        showDiscount.Content = "You are Availing 40% discount";
                    }
                    else if (quantity <= 99)
                    {
                        int counter3 = 100;
                        while (quantity * fixedCost * d3 > fixedCost * counter3 * d4)       ///better deal
                        {
                            counter3++;
                        }
                        result = quantity * fixedCost * d3;
                        discount = quantity * fixedCost * (1 - d3);
                        showMe.Content = "Total Price= $" + result + "\rDiscount   = $" + discount + "\rBuy " + (counter3 - quantity) + " more packages for a better deal by spending a LITTLE MORE.";
                        showDiscount.Content = "You are Availing 40% discount";
                    }
                    else if (quantity >= 100)   ///fourth discount range
                    {
                        result = quantity * fixedCost * d4;
                        discount = quantity * fixedCost * (1 - d4);
                        showMe.Content = "Total Price= $" + result + "\rDiscount   = $" + discount;
                        showDiscount.Content = "You are Availing 50% discount";
                    }
                }
            }
            catch
            { MessageBox.Show("Don't Enter a string."); }
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            showMe.Content = " ";
            showDiscount.Content = " ";
            inputText.Text = " ";
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

