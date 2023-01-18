namespace Burger_MateoAvila;
using Burger_MateoAvila.Models;
using Burger_MateoAvila.Data;


public partial class App : Application
{
    public static BurgerDatabase BurgerRepo { get; set; }
    public App(BurgerDatabase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRepo = repo;

    }
}


