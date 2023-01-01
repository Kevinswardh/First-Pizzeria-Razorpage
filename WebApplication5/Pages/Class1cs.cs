namespace WebApplication5.Pages
{
    public class Class1cs
    {

        public static string GetpopOverPizza()
        {

            string pizzor = "<a class='btn btn-primary mb-2'>Click me!</button></a><br>";

            return pizzor;
        }
        public static string GetpopOverÖvrigt()
        {

            string pizzor2 = "<a class='btn btn-primary mb-2' onclick=\"myFunction()\">Click me!</button></a><br>";

            return pizzor2;
        }
        public static string GetpopOverTillbehör()
        {

            string pizzor3 = "<input type='button'  class='btn btn-primary mb-2' onclick='scrollToTop()' value='Click'>";

            return pizzor3;
        }
    }
}
