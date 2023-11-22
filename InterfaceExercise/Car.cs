﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public string CompanyName { get; set; }
        public string CompanyMotto { get; set; }
        public string SizeOfVehicle { get; set; }
        public string YearMakeModel { get; set; }
        public bool HasTrunk { get; set; }
        public bool UsesFuel { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public int TireSize { get; set; }

        public string Gasoline(bool UsesFuel)
        {
            if (UsesFuel == true)
            {
                return "This car uses gasoline.";
            }
            else
            {
                return "This car does not use deisel.";
            }
        }

        public string Deisel(bool UsesFuel)
        {
            if (UsesFuel == true)
            {
                return "This car uses deisel.";
            }
            else
            {
                return "This car does not use gasoline.";
            }
        }
        public string HasATrunk(bool HasTrunk)
        {
            if (HasTrunk == true)
            {
                return "I have junk in the trunk.";
            }
            else
            {
                return "I have no where to put my junk in a trunk.";
            }
        }

    }

}
