using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAssi
{
   public class ProductRepository
    {
        List<Product> plist = new List<Product>();

        public ProductRepository(List<Product> list)
        {
            plist = list;
        }
       
        public int TotalList(List<Product> plist)
        {
            return plist.Count;
        }

        public List<Product> addProduct(Product p)
        {
            plist.Add(p);
            return plist;
        }

        public List<Product> findProduct(string Type)
        {
            var find = plist.Where(x => x.Type == Type).ToList();
            return find;
        }

        public List<Product> deleteProduct(string Name)
        {
            for (int i = 0; i < plist.Count; i++)
            {
                if (plist[i].Name == Name)
                {
                    plist.RemoveAt(i);
                    break;
                }
                else
                continue;
            }
            return plist;
        }

        public double buyProduct(string Name, int Quantity)
        {
            double total=0;
            foreach (var i in plist)
            {
                if (i.Name == Name)
                    total = (i.Price * Quantity);
            }
            return total;
        }
    }
}
