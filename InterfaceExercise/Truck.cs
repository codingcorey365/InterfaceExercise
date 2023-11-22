using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string CompanyMotto { get; set; }
        public string CompanyName { get; set; }
        public string YearMakeModel { get; set; }
        public string SizeOfVehicle { get; set; }
        public bool HasTruckBed { get; set; }
        
        public bool UsesFuel { get; set; }
        public int NumberOfSeats { get; set; }
        public int NumberOfWheels { get; set; }
        public int TireSize { get; set; }

        public string Diesel(bool UsesFuel)
        {
            if (UsesFuel==true)
            {
                return "This is a diesel truck.";
            }
            else
            {
                return "This truck does not use diesel.";
            }
        }

        public string Gasoline(bool UsesFuel)
        {
            if (UsesFuel == true)
            {
                return "This truck uses gasoline";
            }
            else
            {
                return "This truck does not use gasoline.";
            }
        }

        public string TruckBed(bool HasTruckBed)
        {
            if (HasTruckBed == true)
            {
                return "I have the 8' Long bed for all the storage.";
            }
            else
            {
                return "This truck does not have a truck bed. Am I really a truck?";
            }
        }


    }
}
