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

            var innerJoin = _laptops.Join(_manufacturers,
                laptop => laptop.ManufacturerID,
                manufacturer => manufacturer.Id,
                (laptop, manufacturer) => new
                {
                    manufacturerName = manufacturer.Name,
                    laptopsName = laptop.Name,
                    specificRAM = laptop.RAM
                }).Where(x => x.specificRAM == 8 && x.manufacturerName == "ASUS").Select(x => x.laptopsName);
            foreach (var item in innerJoin)
            {
                Console.WriteLine(item);
            }

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