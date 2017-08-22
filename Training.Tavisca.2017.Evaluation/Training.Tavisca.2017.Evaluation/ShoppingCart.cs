using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Tavisca._2017.Evaluation
{
  public   class ShoppingCart
    {
        public List<Pizza> PizzaList ;
        public ShoppingCart()
        {
            PizzaList = new List<Pizza>();
        }

        public void AddToCart(Pizza Extravangua)
        {
           PizzaList.Add(Extravangua);
        }
        public void ShowTheCart()
        {

            foreach (Pizza e in PizzaList)
            {

            }

        }
        public void GetDetail()
        {

        }

    }
}
