using System;
using System.Collections.Generic;
using System.Text;

namespace AbelAndColeCore.Entities
{
    public class Type
    {
        

        public int IdType { get; set; }
        public string Description { get; set; }

        public Type(int pIdType, string pDescription)
        {
            IdType = pIdType;
            Description = pDescription;
        }
    }


}
