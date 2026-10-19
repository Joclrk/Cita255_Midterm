namespace DemoCode_10_1
{
    public partial class MainPage : ContentPage
    {

        List<string> products = new List<string>();
        public MainPage()
        {
            InitializeComponent();
            for (int i = 0; i < Items.Names.Length; i++)
            {
                products.Add($"{Items.Names[i]} - {Items.Price[i]:C}");
            }
            productList.ItemsSource = products;
        }

        private async void ProductSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.Count == 0)
                return;
           string picked = e.CurrentSelection[0].ToString();
           productList.SelectedItem = null;
           int index = products.IndexOf(picked);
           await Shell.Current.GoToAsync($"ItemPage?index={index}");

        }
    }
}
