using Burger_MateoAvila.Models;
using Burger_MateoAvila.Data;

namespace Burger_MateoAvila.Views;

public partial class BurgerItemPage : ContentPage
{
    Burger Item = new Burger();
    bool _flag;



    public BurgerItemPage()
    {
        InitializeComponent();
        BindingContext = Item;
        
    }
    private void OnSaveClicked(object sender, EventArgs e)
    {
        Item.Name = nameB.Text;
        Item.Description = descB.Text;
        Item.WithExtraCheese = _flag;
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
        MessagingCenter.Send(this, "itemAdded", true);
    }
    private void OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
    private void OnCheckBoxCheckedChanged(object sender,
   CheckedChangedEventArgs e)
    {
        _flag = e.Value;
    }
}