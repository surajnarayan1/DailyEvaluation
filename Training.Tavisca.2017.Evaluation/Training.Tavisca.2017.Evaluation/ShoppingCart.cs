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
        public void ShowTheCart( string name)
        {

          

        }
        public Pizza GetDetailOfPizza(string name)
        {
            foreach (Pizza pizza in PizzaList)
            {
                if (pizza.Name == name)
                {
                    return pizza;
                }
                
                    return null;
            }
            return null;
        }

    }
}
