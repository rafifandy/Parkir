// main


Vehicle[] lot = new Vehicle[lotInput()];
MainMenu.mainMenu(lot);


// lot init
int lotInput(){
    Console.WriteLine("=== PARKING SYSTEM ===");
    Console.WriteLine("Available command ->");
    Console.WriteLine("- create_parking_lot <jumlah>");
    Console.Write("> ");

    string? input = Console.ReadLine();
    string[] read = input.Split(" ");
    if(read.Length == 2 && read[0].Equals("create_parking_lot")) {
        if(int.TryParse(read[1], out _)){
            int size = Int32.Parse(read[1]);
            Console.WriteLine("Created a parking lot with "+size+" slots");
            return size;
        }
        else {
            Console.WriteLine("Invalid create parameter");
            return lotInput();
        }
    }
    else {
        Console.WriteLine("Invalid command");
        return lotInput();
    }
}

