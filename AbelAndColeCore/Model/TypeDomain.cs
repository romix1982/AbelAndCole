using System;
using System.Collections.Generic;
using AbelAndColeCore.Entities;
using Type = AbelAndColeCore.Entities.Type;

namespace AbelAndColeCore.Model
{
    public static class TypeDomain
    {
        public static List<Type> ListTypes { get; set; }


        public static void GenerateTypes()
        {
            ListTypes = new List<Type>()
            {
                new Type(0,"FoodPreferences"),
                new Type(1,"ComunicationPreferences"),
                new Type(2,"FoodInterest"),

            };

        }


    }
}
