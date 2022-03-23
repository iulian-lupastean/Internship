//using Linq.ExtensionMethods;
using LinqLesson;
using Linq.FilteringOperators;
using Linq.AggregationMethods;
using Linq.ConversionMethods;
using System.Collections;
using Linq.ElementOperators;
using Linq.GenerationMethods;
using Linq.Grouping;
using Linq.Joins;
using Linq.Ordering;
using Linq.ProjectionOperators;
using System.Linq;
using Linq.Quantifiers;
using Linq.SetOperators;
using Linq.ExtensionMethods;
namespace LinqAssignment
{
    public static class LinqAssignment
    {

        static void Main(string[] args)
        {
            #region AGGREGATION METHODS
            //AGGREGATION METHODS

            //Count
            // AggregationMethods.CountLaptopsWithSSD(_laptops);

            //Max
            //  AggregationMethods.MaxDiagonalLength(_laptops);

            //Average Price
            //  AggregationMethods.AveragePrice(_laptops);

            //Aggregate
            //  AggregationMethods.AllManufacturers(_manufacturers);
            #endregion

            #region CONVERSION METHODS
            //CONVERSION METHODS

            //OfType
            // ConversionMethods.GetMacBooks(_laptops);

            //Cast ToList
            //  ConversionMethods.CastToList(_laptops);

            //Cast ToArray
            //  ConversionMethods.CastAsArray(_manufacturers);

            //ToDictionary
            // ConversionMethods.ConvertToDictionary(_manufacturers);

            //ToLookUp
            // ConversionMethods.ConvertToLookUp(_laptops);

            //AsEnumerable
            //  int[] array = new int[] { 1, 2, 4, 5, 6 };
            // ConversionMethods.ConvertToAsEnumerable(array);

            //AsQueryable
            //ConversionMethods.ConvertToAsQueryable(_laptops);
            #endregion

            #region ELEMENT OPERATORS
            //ELEMENT OPERATORS

            //FirstOrDefault 
            // ElementOperators.FirstOrDefault(_laptops);

            //LastOrDefault
            //  ElementOperators.LastOrDefault(_laptops);

            //SingleOrDefault
            // ElementOperators.SingleOrDefault(_laptops);

            //ElementAtOrDefault
            //  ElementOperators.ElementAtOrDefault(_laptops);

            //DefaultIfEmpty
            // ElementOperators.DefautIfEmpty(_laptops);
            #endregion

            #region FILTERING OPERATORS
            //FILTERING OPERATORS

            //Where
            // FilteringOperators.SelectWhere(_laptops);

            //Take and Skip
            // FilteringOperators.TakeThenSkip(_laptops);

            //TakeWHile
            // FilteringOperators.TakeLaptopsWhile(_laptops);

            //SkipWhile
            //  FilteringOperators.SkipLaptopsWhile(_laptops);

            //Distinct 
            //FilteringOperators.Distinct(_laptops);
            #endregion

            #region GENERATION METHODS
            //Empty 
            // IEnumerable<Tablet> _tablets = GenerationMethods.GenerateEmptyTabletList();

            //Repeat
            // GenerationMethods.RepeatStringNTimes("Alea Acta Est", 10);

            //Range
            // GenerationMethods.Range(18, 30);

            #endregion

            #region GROUPING
            // Grouping.GroupByCapacity(_laptops);
            #endregion

            #region Joins
            //Join
            //Joins.AvailableLaptopsFromManufacturers(_laptops, _manufacturers);

            //GroupJoin
            // Joins.AvailableLaptopsFromManufacturersByID(_laptops, _manufacturers);

            //Zip
            // int[] arabic = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // string[] roman = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X" };
            // Joins.Zipp(roman, arabic);
            #endregion

            #region ORDERING
            //OrderBy ThenBy ASC
            // Ordering.OrderByCapacityThenByRAMAsc(_laptops);

            //OrderBy ThenBy DESC
            /*
            var ordered = Ordering.OrderByPriceThenByFrequencyDesc(_laptops);
            foreach (var item in ordered)
            {
                Console.WriteLine(item);
            }

            //Reverse 
            var reversed = Ordering.ReversedList(ordered);
            foreach (var item in reversed)
            {
                Console.WriteLine(item);
            }
            */
            #endregion

            #region PROJECTION OPERATORS

            //Select
            // ProjectionOperators.SelectName(_laptops);

            //SelectMany
            /*
            int[][] matrix = new int[][]
            {
                new [] {1,2,3},
                new [] {4,3,4,5,2},
                new [] {5,6,7,8,9}
            };
            ProjectionOperators.SelectMany(matrix);
            */

            #endregion

            #region Quantifiers
            //Contains
            // Laptop laptop = new Laptop { Name = "Laptop ASUS Gaming ASUS TUF F15", Price = 2999.99, ProcesorFrequency = 2.5, RAM = 8, Capacity = 512, ScreenDiagonal = 15.6, ManufacturerID = "FX506LH-HN004", HasSSD = true };
            //Quantifiers.CheckIfContains(_laptops, laptop);


            //Any
            /*
            if (Quantifiers.MacBooksInStock(_laptops))
            {
                Console.WriteLine("There are MackBooks in stock");
            }
            */

            //All
            /*
            if (Quantifiers.AllLaptopHasSSD(_laptops))
            {
                Console.WriteLine("All laptops have SSD");
            }
            else { Console.WriteLine("Not all laptops have SSD"); }
            */

            //SequenceEmpty
            // Quantifiers.IsListEmpty(_laptops);

            #endregion

            #region SET OPERATORS
            //Concat
            // SetOperators.ConcatenateLists(_laptops, _onsale);

            //Union
            //SetOperators.UniteLists(_laptops, _onsale);

            //Intersect
            //SetOperators.OnSaleRemainingStock(_onsale, _laptops);

            //Except
            //SetOperators.OnSaleOutofStock(_laptops, _onsale);
            #endregion

        }

        private static readonly IEnumerable<Laptop> _laptops = CreateLaptopsList();

        private static IEnumerable<Laptop> CreateLaptopsList()
        {
            return new List<Laptop>
            {
                new Laptop {Name="Laptop ASUS Gaming ASUS TUF F15",Price=2999.99,ProcesorFrequency=2.5,RAM=8,Capacity=512,ScreenDiagonal=15.6,ManufacturerID="FX506LH-HN004",HasSSD=true},
                new Laptop {Name="Laptop ASUS Gaming ASUS TUF A15",Price=3298.99,ProcesorFrequency=3.3,RAM=8,Capacity=512,ScreenDiagonal=15.6,ManufacturerID="FX506LH-HN004",HasSSD=true},
                new Laptop {Name="Laptop Lenovo Gaming IdeaPad 3",Price=3199.99,ProcesorFrequency=3.3,RAM=8,Capacity=256,ScreenDiagonal=15.6,ManufacturerID="82K2007ARM",HasSSD=true},
                new Laptop {Name="Laptop Lenovo Gaming Legion 5",Price=3999.99,ProcesorFrequency=2.5,RAM=8,Capacity=512,ScreenDiagonal=15.6,ManufacturerID="82K2007ARM",HasSSD=false},
                new Laptop {Name="Laptop Lenovo Gaming Legion S7",Price=5799.99,ProcesorFrequency=3.3,RAM=16,Capacity=512,ScreenDiagonal=15.6,ManufacturerID="82K2007ARM",HasSSD=true},
                new Laptop {Name="Laptop Acer Gaming Nitro 5",Price=3399.99,ProcesorFrequency=2.5,RAM=8,Capacity=512,ScreenDiagonal=15.6,ManufacturerID="NH.QB0EX.001",HasSSD=false},
                new Laptop {Name="Laptop GIGABYTE Gaming G7 KC",Price=7199.99,ProcesorFrequency=2.2,RAM=2,Capacity=512,ScreenDiagonal=17.3,ManufacturerID="G7 KC-8EE1130SH",HasSSD=true},
                new MacBook {Name="Laptop Apple MacBook Air 13",Price=4699.99,AppleProcesor="Apple M1 chip (8-core CPU)",RAM=8,Capacity=256,ScreenDiagonal=13.3,ManufacturerID="MGND3ZE/A",HasSSD=false},
            };
        }

        private static readonly IEnumerable<Laptop> _onsale = CreateOnSaleList();
        private static IEnumerable<Laptop> CreateOnSaleList()
        {
            return new List<Laptop>
            {

                new Laptop {Name="Laptop Lenovo Gaming Legion S7",Price=5799.99,ProcesorFrequency=3.3,RAM=16,Capacity=512,ScreenDiagonal=15.6,ManufacturerID="82K2007ARM",HasSSD=true},
                new Laptop {Name="Laptop Acer Gaming Nitro 5",Price=3399.99,ProcesorFrequency=2.5,RAM=8,Capacity=512,ScreenDiagonal=15.6,ManufacturerID="NH.QB0EX.001",HasSSD=false},
                new Laptop {Name="Laptop GIGABYTE Gaming G7 KC",Price=6199.99,ProcesorFrequency=2.5,RAM=2,Capacity=512,ScreenDiagonal=17.3,ManufacturerID="G7 KC-8EE1130SH",HasSSD=false},

            };
        }
        public static IEnumerable<Manufacturer> _manufacturers = CreteManufacturersList();
        private static IEnumerable<Manufacturer> CreteManufacturersList()
        {
            return new List<Manufacturer>{
                new Manufacturer { Id = "FX506LH-HN004", Name = "ASUS", CEO = "Jonney Shih",
                    Laptops = new List<Laptop> { new Laptop() { Name = "TUF15" }, new Laptop() { Name = "A15" } } },
                new Manufacturer { Id = "82K2007ARM",Name="Lenovo",CEO="Yang Yuanqing",
                    Laptops=new List<Laptop> { new Laptop() { Name ="IdeaPad3"}, new Laptop() { Name ="Legion 5"},new Laptop() { Name ="Legion S7"} }},
                new Manufacturer { Id ="NH.QB0EX.001",Name="Acer",CEO="Jason Chen",
                    Laptops= new List<Laptop> { new Laptop() { Name ="Nitro 5"} } },
                new Manufacturer { Id ="G7 KC-8EE1130SH",Name="GIGABYTE",CEO="Ming-Hsiung Liu ",
                    Laptops=new List<Laptop>{ new Laptop() {Name="G7 KC"} } },
                new Manufacturer{ Id ="MGND3ZE/A",Name="Apple",CEO="Tim Cook",
                    Laptops=new List<Laptop>{ new Laptop() { Name="Macbook Air 13"} } },
            };
        }

    }


}