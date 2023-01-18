using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Burger_MateoAvila.Models;
using SQLite;


namespace Burger_MateoAvila.Data
{
    public class BurgerDatabase
    {
        string _dbPath;
        private SQLiteConnection conn;
        public BurgerDatabase(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<Burger>();
        }
        public int AddNewBurger(Burger burger)
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
        public List<Burger> GetAllBurgers()
        {
            Init();
            List<Burger> burgers = conn.Table<Burger>().ToList();
            return burgers;
        }

        public int DeleteItem(Burger item)
        {
            Init();
            return conn.Delete(item);
        }

        public Burger ShowItem(Burger item)
        {
            Init();
            List<Burger> burgers = conn.Table<Burger>().ToList();
            return null;
        }
    }
}

