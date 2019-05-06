using System;
using System.Collections.Generic;
using System.Text;

namespace AbelAndColeCore.Entities
{
    public class Value
    {
        public int IdValue { get; set; }
        public string Description { get; set; }
        public Type TypeValue { get; set; }


        public Value(int pIdValue, string pDescription, Type pType)
        {
            IdValue = pIdValue;
            Description = pDescription;
            TypeValue = pType;
        }

    }
}
