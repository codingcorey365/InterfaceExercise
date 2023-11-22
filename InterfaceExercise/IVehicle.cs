using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; } 
        public bool UsesFuel { get; set; }
        public int TireSize  { get; set; }

        
    }
}