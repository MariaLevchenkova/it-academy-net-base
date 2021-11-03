using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var motorcycle = new Motorcycle();
            
            var vin = motorcycle.inVinPublic;
            var odometr = motorcycle.OdometrPublic;
            motorcycle.StartEnginePublic();

            vin = motorcycle.inVinInternal;
            odometr = motorcycle.OdometrInteral;
            motorcycle.StartEngineInternal();

            vin = motorcycle.inVinProtecteInternal;
            odometr = motorcycle.OdometrProtectecInteral;
            motorcycle.StartEngineProtecteInternal();

            var sportBike = new SportBike();

            vin = sportBike.inVinPublic;
            odometr = sportBike.OdometrPublic;
            sportBike.StartEnginePublic();
            
            vin = sportBike.inVinInternal;
            odometr = sportBike.OdometrInteral;
            sportBike.StartEngineInternal();

            vin = sportBike.inVinProtecteInternal;
            odometr = sportBike.OdometrProtectecInteral;
            sportBike.StartEngineProtecteInternal();

            // private - не компилируется, потому что доступен только в том типе, в которой определен.

            //private protected не копилируется, потому что  ограничен  содержащим классом,
            //которые являются наследниками от содержащего класса в текущей сборке.

            //protected не копилируется , потому что доступен в типе. котором определен, и его наследниках(этого типа).
        }
    }
}
