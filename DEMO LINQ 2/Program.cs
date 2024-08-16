
using System.Collections;
using static DEMO_LINQ_2.ListGenerator;
namespace DEMO_LINQ_2
{
    class Program
    {
        static void Main()
        {
            #region Casting operatores
            //// ToList
            //List<Product> Result = ProductsList.Where(P => P.UnitsInStock == 0).ToList();
            //// ToArray
            //Product[] Result0 = ProductsList.Where(P=> P.UnitPrice == 0).ToArray();
            //// ToDict 
            //Dictionary<long, Product> Result1 = ProductsList.Where(P => P.UnitPrice == 0)
            //    .ToDictionary(P => P.ProductID);
            ////HashSet
            //HashSet<Product> Result2 = ProductsList.Where(P => P.UnitPrice == 0).ToHashSet();
            //foreach (var item in Result2)
            //{
            //    Console.WriteLine(item);
            //}
            //// ArrayList
            //ArrayList Result3 = new ArrayList()
            //{
            //    "omar" ,
            //    "ahmed" ,
            //    "hesham" ,
            //    55 ,
            //    "A"
            //};

            //var Result4 = Result3.OfType<int>().ToList(); // print what you define in <>  // output : 55
            //var Result5 = Result3.OfType<string>().ToList(); // print what you define in <> // "omar"...
            //var Result6 = Result3.OfType<char>().ToList(); // print what you define in <> // "A"
            #endregion






            #region Generation operators

            //var Result = Enumerable.Range(0, 100);
            //var Result1 = Enumerable.Repeat(2, 100);
            //var Result3 = Enumerable.Repeat("hesham", 100);
            var Result4 = Enumerable.Repeat(new Product(), ProductsList.Count());

            var reaulttt = Enumerable.Empty<Product>().ToArray(); // empty 

            Product[] products = new Product[0]; // empty
            // create list of prooducts and they are Empty : 
            var List = Enumerable.Empty<Product>().ToList(); 
            foreach (var item in Result4)
            {
                Console.Write($"{item} ");
            }
            #endregion


            #region Set Operators

            // Union > without duplication
            // Concat > With duplication
            // Intersect 
            // Expect 
            // Distinct > remove Duplicates
            #endregion

            #region Quantifier Operators - Return Boolean
            // Any();
            // do this res has any element ?  if yes at least one element it will be return true 
            //and if its not it will return false
            var res = ProductsList.Any(); 
            // do any element match this condition ? if yes will return true.
            res = products.Any(P => P.UnitsInStock == 0); 
            res = products.Any(P => P.UnitsInStock > 1000);

            // All();
            // do all lements in match this condition ? if yes return true
            res = ProductsList.All(P => P.UnitsInStock == 0); 
            Console.WriteLine(res);
            #endregion
















        }
    }
}