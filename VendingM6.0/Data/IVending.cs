using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingM6._0.Models;

namespace VendingM6._0.Data
{
    public interface IVending
    {
        public string ShowAll();
        public void InsertMoney(int addedMoney);
        public Dictionary<int, int> EndTransaction();
        public Product Purchase(int id);
    }
}
