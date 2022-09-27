using Class71Exercise;
internal class Program {
    private static void Main(string[] args) {

        Console.WriteLine("How many romms will be rented?! ");
        int rented = int.Parse(Console.ReadLine());

        Rent[] vect = new Rent[10];

        for (int i = 0; i < rented; i++) {
            Console.WriteLine($"Rent #{i+1}: ");
            
            Console.Write("Name: ");
            string name = Console.ReadLine();
            
            Console.Write("Email: ");
            string email = Console.ReadLine();
            
            Console.Write("Room: ");
            int room = int.Parse(Console.ReadLine());

            vect[room] = new Rent { Name = name, Email = email, Room = room };
        }

        for (int i = 0; i < 10; i++) {
            if (vect[i] != null) {
                Console.WriteLine(vect[i]);
            }
        
        }
    
    }
}