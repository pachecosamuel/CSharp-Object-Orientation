namespace Class71Exercise {
    internal class Rent {

        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public override string ToString() {
            return Name + " ," + Email;
        }
    }
}
