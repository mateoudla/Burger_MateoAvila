namespace Burger_MateoAvila;
using Burger_MateoAvila.Models;
using Burger_MateoAvila.Data;


public partial class App : Application
{
    public static BurgerDatabaseMA BurgerRepo { get; set; }
    public App(BurgerDatabaseMA repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRepo = repo;

    }
}


