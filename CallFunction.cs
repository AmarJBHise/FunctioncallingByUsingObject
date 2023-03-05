using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functioncalling
{
    internal class CallFunction
    {
         public static void Staticfunction()
        {

        }
        

        
        public static void Staticfunction1()
        {
            Staticfunction();

            CallFunction ABC = new CallFunction();
            ABC.nonstaticfuction1();               // calling Non Static Function From Static
                                                   // Function
            
        }

        public void nonstaticfuncation()
        {
            nonstaticfuction1();
            Staticfunction1();                   // Calling Static Fuction From
                                                // Non Static Function 

        }

        public void nonstaticfuction1()
        {

        }
    }
}
