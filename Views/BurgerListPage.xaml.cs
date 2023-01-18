using Burger_MateoAvila.Models;

namespace Burger_MateoAvila.Views;

public partial class BurgerListPage : ContentPage
{
    public event EventHandler AddBurger;

    public BurgerListPage()
    {
        InitializeComponent();
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
        MessagingCenter.Subscribe<BurgerItemPage>(this, "itemAdded", (sender) => OnUpdate(sender, EventArgs.Empty));
    }

    private void OnUpdate(object sender, EventArgs e)
    {
        //fetch new items and update the Burgers property
        List<Burger> newBurgers = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = newBurgers;
        AddBurger?.Invoke(this, EventArgs.Empty);
    }


    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage));
    }

    private void OnUpdateButtonClicked(object sender, EventArgs e)
    {
        OnUpdate(sender, e);
    }
}
