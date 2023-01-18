using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Burger_MateoAvila.Models;
using SQLite;


namespace Burger_MateoAvila.Data
{
    public class BurgerDatabaseMA
    {
        string _dbPath;
        private SQLiteConnection conn;
        public BurgerDatabaseMA(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BurgerMA>();
        }
        public int AddNewBurger(BurgerMA burger)
        {
            Init();
            if (burger.Id != 0)
            {
                return conn.Update(burger);
            }
            else
            {
                return conn.Insert(burger);
            }
        }
        public List<BurgerMA> GetAllBurgers()
        {
            Init();
            List<BurgerMA> burgers = conn.Table<BurgerMA>().ToList();
            return burgers;
        }

        public int DeleteItem(BurgerMA item)
        {
            Init();
            return conn.Delete(item);
        }

        public BurgerMA ShowItem(BurgerMA item)
        {
            Init();
            List<BurgerMA> burgers = conn.Table<BurgerMA>().ToList();
            return null;
        }
    }
}

