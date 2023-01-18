using Burger_MateoAvila.Models;
using Burger_MateoAvila.Data;

namespace Burger_MateoAvila.Views;
[QueryProperty("Item", "Item")]

public partial class BurgerItemPage : ContentPage
{

    public BurgerMA Item
    {
        get => BindingContext as BurgerMA;
        set => BindingContext = value;
    }

    public BurgerItemPage()
    {
        InitializeComponent();
    }
    private void OnSaveClickedMA(object sender, EventArgs e)
    {
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }
    private void OnCancelClickedMA(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void OnDeleteClickedMA(object sender, EventArgs e)
    {
        App.BurgerRepo.DeleteItem(Item);
        Shell.Current.GoToAsync("..");
    }
}