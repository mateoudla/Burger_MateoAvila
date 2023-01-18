using Burger_MateoAvila.Models;

namespace Burger_MateoAvila.Views;

public partial class BurgerListPage : ContentPage
{
    public BurgerListPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    public void OnItemAddedMA(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new BurgerMA()
        });
    }

    private void OnUpdateMA(object sender, EventArgs e)
    {
        List<BurgerMA> newBurgers = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
    }

    private void OnUpdateButtonClicked(object sender, EventArgs e)
    {
        OnUpdateMA(sender, e);
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        List<BurgerMA> newBurgers = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
    }

    private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        BurgerMA burgers = e.CurrentSelection.FirstOrDefault() as BurgerMA;
        if (burgers == null)
            return;
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            {"Item", burgers }
        });
        ((CollectionView)sender).SelectedItem = null;

    }
}
