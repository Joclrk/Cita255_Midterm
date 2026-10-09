namespace DemoCode_10_1
{
    public partial class MainPage : ContentPage
    {
        List<string> products =
        [
            "Plain Bagel",
            "Cheese Bagel",
            "Pizza Bagel",
            "Rotten Bagel"
        ];

        public MainPage()
        {
            InitializeComponent();
            productList.ItemsSource = products;
        }

        private void OnProductSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count > 0)
            {
                string picked = e.CurrentSelection[0].ToString();

                productList.SelectedItem = null;

                if (picked == "Plain Bagel") {
                    Shell.Current.GoToAsync("PlainBagel");
                }else if(picked == "Cheese Bagel")
                {
                    Shell.Current.GoToAsync("CheeseBagel");
                }
                else if (picked == "Pizza Bagel")
                {
                    Shell.Current.GoToAsync("PizzaBagel");
                }
                else if (picked == "Rotten Bagel")
                {
                    Shell.Current.GoToAsync("RottenBagel"); //chossen out of stock for midterm 
                }
            }
        }
    }
}
