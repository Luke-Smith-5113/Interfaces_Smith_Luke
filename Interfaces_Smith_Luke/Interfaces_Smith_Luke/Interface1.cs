using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Smith_Luke
{
    interface IGenre
    {
        //creates a bunch of string to be used in classes that use the IGenre interface
        public string ESRB { get; }
        public string Genre { get; }
        public string Title { get; }
        //Creates a string function to be used later
        public string Describe();
    }
}
