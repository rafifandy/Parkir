class MainMenu {
    public static void mainMenu(Vehicle[] lot){
        Console.WriteLine("\n=== PARKING SYSTEM ===");
        Console.WriteLine("-2000/jam | 1jam = 10 detik (untuk testing)-");
        Console.WriteLine("Available command -> ");
        Console.WriteLine("- park <plat_nomor> <warna> <jenis_kendaraan>");
        Console.WriteLine("- leave <nomor_lot>");
        Console.WriteLine("- status");
        Console.WriteLine("- type_of_vehicles <jenis_kendaraan>");
        Console.WriteLine("- registration_numbers_for_vehicles_with_odd_plate");
        Console.WriteLine("- registration_numbers_for_vehicles_with_even_plate");
        Console.WriteLine("- registration_numbers_for_vehicles_with_colour <warna>");
        Console.WriteLine("- slot_numbers_for_vehicles_with_colour <warna>");
        Console.WriteLine("- slot_number_for_registration_number <plat_nomor>");
        Console.WriteLine("- exit");
        Console.Write("> ");
        
        string? input = Console.ReadLine();
        string[] read = input.Split(" ");

        //  park
        if(read[0].Equals("park")) {
            if(read.Length == 4) {
                mainMenu(Menu.park(lot, read));
            } else {
                Console.WriteLine("Invalid park parameter");
                mainMenu(lot);
            }
        }

        //  leave
        else if(read[0].Equals("leave")) {
            if(read.Length == 2 && int.TryParse(read[1], out _)) {
                mainMenu(Menu.leave(lot, Int32.Parse(read[1])));
            } else {
                Console.WriteLine("Invalid leave parameter");
                mainMenu(lot);
            }
        } 

        //  status
        else if(read[0].Equals("status")) {
            Menu.status(lot);
            mainMenu(lot);
        }

        //  type_of_vehicles
        else if(read[0].Equals("type_of_vehicles")) {
            if(read.Length == 2) {
                Menu.typeOfVehicles(lot, read[1]);
                mainMenu(lot);
            } else {
                Console.WriteLine("Invalid type_of_vehicles parameter");
                mainMenu(lot);
            }
        }

        //  odd_plate
        else if(read[0].Equals("registration_numbers_for_vehicles_with_odd_plate")) {
            Menu.oddPlate(lot);
            mainMenu(lot);
        } 

        //  even_plate
        else if(read[0].Equals("registration_numbers_for_vehicles_with_even_plate")) {
            Menu.evenPlate(lot);
            mainMenu(lot);
        }

        // reg colour
        else if(read[0].Equals("registration_numbers_for_vehicles_with_colour")) {
            if(read.Length == 2) {
                Menu.lotColour(lot, read[1]);
                mainMenu(lot);
            } else {
                Console.WriteLine("Invalid colour parameter");
                mainMenu(lot);
            }
        }

        // lot colour
        else if(read[0].Equals("slot_numbers_for_vehicles_with_colour")) {
            if(read.Length == 2) {
                Menu.lotColour(lot, read[1]);
                mainMenu(lot);
            } else {
                Console.WriteLine("Invalid colour parameter");
                mainMenu(lot);
            }
        }

        // reg number
        else if(read[0].Equals("slot_number_for_registration_number")) {
            if(read.Length == 2) {
                Menu.regNumber(lot, read[1]);
                mainMenu(lot);
            } else {
                Console.WriteLine("Invalid registration_number parameter");
                mainMenu(lot);
            }
        } 

        else if(read[0].Equals("exit")) {
            
        }  
        
        else {
            Console.WriteLine("Invalid command");
            mainMenu(lot);
        }
    }
}