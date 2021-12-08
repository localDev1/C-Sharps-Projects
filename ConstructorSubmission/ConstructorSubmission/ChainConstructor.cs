using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorSubmission
{
    public class ChainConstructor
    {
        //Chain two constructors together.
        public ChainConstructor():this("pendiente", "pendiente") 
        {
        }

        public ChainConstructor(string fname, string lname) 
        {
            firstName = fname;
            lastName = lname;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        
    }
}
