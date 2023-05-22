class Menu {
    public static Vehicle[] park(Vehicle[] lot, string[] value) {
        if (value[3].Equals("motor", StringComparison.OrdinalIgnoreCase) || value[3].Equals("mobil", StringComparison.OrdinalIgnoreCase)) {
            Vehicle vehicle = new Vehicle(value[1], value[2], value[3], DateTime.Now);
            for (int i = 0; i < lot.Length; i++) {
                if (lot[i] == null) {
                    lot[i] = vehicle;
                    Console.WriteLine("Allocated slot number: "+(i+1));
                    return lot;
                }
            }
        } else {
            Console.WriteLine("Sorry, Mobil and Motor only");
            return lot;
        }
        Console.WriteLine("Sorry, parking lot is full");
        return lot;
    }
    public static Vehicle[] leave(Vehicle[] lot, int value) {
        int v = value - 1;
        if(lot[v] != null) {
            int duration = (int)(DateTime.Now - lot[v].DateTime).TotalSeconds / 10;
            int parkingFee = 2000 + (duration * 2000);
            Console.WriteLine(lot[v].Number+" | Parking duration : "+duration+" | Parking fee : "+parkingFee);
            lot[v] = null;
            Console.WriteLine("Slot number "+value+" is free");
            return lot;
        }
        Console.WriteLine("Slot number "+value+" is already empty");
        return lot;
    }
    public static void status(Vehicle[] lot) {
        int occupied = 0;
        int available = 0;
        int duration = 0;
        int parkingFee = 0;
        Console.WriteLine("|{0,4}|{1,16}|{2,16}|{3,16}|{4,24}|{5,16}|{6,16}|", "Lot", "Nomor Plat", "Warna", "Jenis", "Check-in", "Durasi Parkir", "Biaya");
        for (int i = 0; i < lot.Length; i++) {
            if (lot[i] != null) {
                occupied++;
                duration = (int)(DateTime.Now - lot[i].DateTime).TotalSeconds / 10;
                parkingFee = 2000 + (duration * 2000);
                Console.WriteLine("|{0,4}|{1,16}|{2,16}|{3,16}|{4,24}|{5,16}|{6,16}|", i+1, lot[i].Number, lot[i].Color,  lot[i].Type, lot[i].DateTime, duration, parkingFee);
            } else {
                available++;
            }
        }
        Console.WriteLine("Occupied = "+occupied);
        Console.WriteLine("Available = "+available);
    }

    public static void typeOfVehicles(Vehicle[] lot, string value) {
        int count = 0;
        for (int i = 0; i < lot.Length; i++) {
            if (lot[i] != null && lot[i].Type.Equals(value, StringComparison.OrdinalIgnoreCase)) {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    public static void oddPlate(Vehicle[] lot) {
        int count = 0;
        for (int i = 0; i < lot.Length; i++) {
            if (lot[i] != null && Int32.Parse(lot[i].Number.Where(Char.IsDigit).ToArray()) % 2 == 1) {
                count++;
                Console.Write(lot[i].Number+", ");
            }
        }
        Console.WriteLine("Total = "+count);
    }

    public static void evenPlate(Vehicle[] lot) {
        int count = 0;
        for (int i = 0; i < lot.Length; i++) {
            if (lot[i] != null && Int32.Parse(lot[i].Number.Where(Char.IsDigit).ToArray()) % 2 == 0) {
                count++;
                Console.Write(lot[i].Number+", ");
            }
        }
        Console.WriteLine("Total = "+count);
    }

    public static void regColour(Vehicle[] lot, string value) {
        int count = 0;
        for (int i = 0; i < lot.Length; i++) {
            if (lot[i] != null && lot[i].Color.Equals(value, StringComparison.OrdinalIgnoreCase)) {
                count++;
                Console.Write(lot[i].Number+", ");
            }
        }
        Console.WriteLine("Total = "+count);
    }

    public static void lotColour(Vehicle[] lot, string value) {
        int count = 0;
        for (int i = 0; i < lot.Length; i++) {
            if (lot[i] != null && lot[i].Color.Equals(value, StringComparison.OrdinalIgnoreCase)) {
                count++;
                Console.Write((i+1)+", ");
            }
        }
        Console.WriteLine("Total = "+count);
    }

    public static void regNumber(Vehicle[] lot, string value) {
        for (int i = 0; i < lot.Length; i++) {
            if (lot[i] != null && lot[i].Number.Equals(value)) {
                Console.WriteLine(i+1);
            }
        }
    }
}