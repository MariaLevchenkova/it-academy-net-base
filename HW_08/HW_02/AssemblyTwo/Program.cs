using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorcycle = new Motorcycle();
            var vin = motorcycle.inVinPublic;
            var odometr = motorcycle.OdometrPublic;
            motorcycle.StartEnginePublic();

            var sportBike = new SportBike();
            sportBike.StartEnginePublic();
            odometr = sportBike.OdometrPublic;
            vin = sportBike.inVinPublic;

            // private - не компилируется, потому что доступен только в том типе, в которой определен.

            //private protected не копилируется, потому что  ограничен  содержащим классом,
            //которые являются наследниками от содержащего класса в текущей сборке.

            //protected не копилируется, потому что доступен в типе. котором определен, и его наследниках(этого типа).

            //internal не копилируется, потому что без ограничений. работает в той сборке где описан.  

            //protected internal не копилируется, потому что видет в содержащий его сборке без ограничений,вне сборки -в наследниках типа.
        }
    }
}
