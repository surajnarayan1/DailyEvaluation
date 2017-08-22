using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Training.Tavisca._2017.Evaluation;


namespace PizzaTest
{
    [TestClass]
    public class PizzaTest
    {
        

        [TestMethod]
        public void Adding_Pizza_To_Cart_checking_The_Content_In()

        {
            ShoppingCart shoppingCart = new ShoppingCart();

            Pizza firstPizza = new Pizza();
           firstPizza.Name="supreme";
            firstPizza.Price = 123;
            firstPizza.Type = "Veg";
            shoppingCart.AddToCart(firstPizza);
            Pizza secondPizza = new Pizza();
            secondPizza.Name = "ExtraCheesy";
            secondPizza.Price = 100;
            secondPizza.Type = "NonVeg";
            shoppingCart.AddToCart(secondPizza);
            Assert.AreSame(firstPizza.Name, shoppingCart.GetDetailOfPizza("supreme").Name);





        }
    }
}
