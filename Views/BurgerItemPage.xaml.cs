using Burger_MateoAvila.Models;
using Burger_MateoAvila.Data;

namespace Burger_MateoAvila.Views;
[QueryProperty("Item", "Item")]

public partial class BurgerItemPage : ContentPage
{

    public Burger Item
    {
        get => BindingContext as Burger;
        set => BindingContext = value;
    }

    public BurgerItemPage()
    {
        InitializeComponent();
    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void OnDeleteClicked(object sender, EventArgs e)
    {
        App.BurgerRepo.DeleteItem(Item);
        Shell.Current.GoToAsync("..");
    }
}