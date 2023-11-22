using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Done: Create 2 Interfaces called IVehicle & ICompany

            //Done: Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Done: Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Done: Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            // Done: In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Done: Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Done: Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            var GeoMetro = new Car();
            GeoMetro.CompanyMotto = "Geo Anywhere";
            GeoMetro.CompanyName = "Geo George";
            GeoMetro.SizeOfVehicle = "small";
            GeoMetro.YearMakeModel = "2023 Geo Metro";
            GeoMetro.HasTrunk = false;
            GeoMetro.UsesFuel = true;
            GeoMetro.TireSize = 15;
            GeoMetro.NumberOfSeats = 5;
            GeoMetro.NumberOfWheels = 4;

            Console.WriteLine($"Here at {GeoMetro.CompanyName}, we like to say \"{GeoMetro.CompanyMotto}!\" We have a brand new {GeoMetro.YearMakeModel} just for you. it has {GeoMetro.TireSize} inch tires, {GeoMetro.NumberOfSeats} seats, and if you must know it has {GeoMetro.NumberOfWheels} working tires. This is a {GeoMetro.SizeOfVehicle} driving machine. This baby still uses fuel. {GeoMetro.Deisel(GeoMetro.UsesFuel)} {GeoMetro.HasATrunk(GeoMetro.HasTrunk)}");



            Console.WriteLine("----------------------------------------");

            var Tahoe = new Suv();
            Tahoe.CompanyMotto = "All paying customers welcome";
            Tahoe.CompanyName = "Marlon's Chevy";
            Tahoe.SizeOfVehicle = "large";
            Tahoe.YearMakeModel = "2023 Chevy Tahoe";
            Tahoe.HasTrunk = true;
            Tahoe.UsesFuel = true;
            Tahoe.TireSize = 17;
            Tahoe.NumberOfSeats = 8;
            Tahoe.NumberOfWheels = 4;

            Console.WriteLine($"Here at {Tahoe.CompanyName}, we like to say \"{Tahoe.CompanyMotto}!\" We have a brand new {Tahoe.YearMakeModel} just for you. it has {Tahoe.TireSize} inch tires, {Tahoe.NumberOfSeats} seats, and if you must know it has {Tahoe.NumberOfWheels} working tires. This is a {Tahoe.SizeOfVehicle} driving machine. This baby still uses fuel. {Tahoe.Gasoline(Tahoe.UsesFuel)} {Tahoe.HasATrunk(Tahoe.HasTrunk)}");

            Console.WriteLine("----------------------------------------");

            var megaTruck = new Truck();
            megaTruck.CompanyName = "Marlon's Chevy";
            megaTruck.CompanyMotto = "At least its big";
            megaTruck.YearMakeModel = "2023 Ford F-350";
            megaTruck.SizeOfVehicle = "large";
            megaTruck.HasTruckBed = true;
            megaTruck.UsesFuel = true;
            megaTruck.TireSize = 33;
            megaTruck.NumberOfSeats = 5;
            megaTruck.NumberOfWheels = 4;
            
            Console.WriteLine("----------------------------------------");

            Console.WriteLine($"Here at {megaTruck.CompanyName}, we like to say \"{megaTruck.CompanyMotto}!\" We have a brand new {megaTruck.YearMakeModel} just for you. it has {megaTruck.TireSize} inch tires, {megaTruck.NumberOfSeats} seats, and if you must know it has {megaTruck.NumberOfWheels} working tires. This is a {megaTruck.SizeOfVehicle} hauling machine None of that yuppie electrified crap. This baby still uses fuel. {megaTruck.Diesel(megaTruck.UsesFuel)}. What a great way to put this haulin machine to work, with that truck bed. {megaTruck.TruckBed(megaTruck.HasTruckBed)}");
        }
    }
}
