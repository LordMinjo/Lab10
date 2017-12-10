using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //origen de datos 
            NorthwndDataContext context = new NorthwndDataContext();

            //creación de consulta 
            var product = (from p in context.Products
                           where p.ProductID == 78
                           select p).FirstOrDefault();

            //Ejecución de consulta 
            context.Products.DeleteOnSubmit(product);
            context.SubmitChanges();
        }
    }
}
