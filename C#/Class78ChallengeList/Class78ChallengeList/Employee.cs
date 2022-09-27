namespace Class78ChallengeList {
    internal class Employee {

        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee() {
        }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void Readjustment(double value) {
            Salary += Salary * value / 100.0;
        }

        public override string ToString() {
            return "ID: " + Id + ", Name: " + Name + ", " + "Salary: " + Salary;
        }
    }
}
