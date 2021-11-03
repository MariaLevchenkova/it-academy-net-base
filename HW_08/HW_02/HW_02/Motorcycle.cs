using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyOne
{
     public class Motorcycle
    {
         const ushort MaxSpeed = 350;
         string inVin = "1HG-EM1154-YL048297";
         int odometr = 10000;

        void StartEngine()
        {
        }
        //private
       private const ushort MaxSpeedPrivate = 350;
       private string inVinPrivate = "1HG-EM1154-YL048297";
       private int OdometrPrivate { get; set; } = 10_000;

       private void StartEnginePrivat()
        {
        }

        // internal
       internal const ushort MaxSpeedInternal = 350;
        internal string inVinInternal = "1HG-EM1154-YL048297";
         internal int OdometrInteral { get; set; } = 10_000;

        internal void StartEngineInternal()
        {
        }

        // public 
        public const ushort MaxSpeedPublic = 350;
        public  string inVinPublic = "1HG-EM1154-YL048297";
         public  int OdometrPublic { get; set; } = 10_000;

        public void StartEnginePublic()
        {
        }

        // protected
        protected const ushort MaxSpeedProtecte = 350;
        protected string inVinProtecte = "1HG-EM1154-YL048297";
        protected int OdometrProtectec { get; set; } = 10_000;

        protected void StartEngineProtecte()
        {
        }

        //protected internal
        protected internal const ushort MaxSpeedProtecteInternal = 350;
        protected internal string inVinProtecteInternal = "1HG-EM1154-YL048297";
        protected internal int OdometrProtectecInteral { get; set; } = 10_000;

        protected internal void StartEngineProtecteInternal()
        {
        }

        //private protected
        private protected const ushort MaxSpeedPrivateProtecte = 350;
        private protected string inVinPrivateProtecte = "1HG-EM1154-YL048297";
        private protected int OdometrPrivareProtectec { get; set; } = 10_000;

        private protected void StartEnginePrivateProtecte()
        {
        }
    }
}
