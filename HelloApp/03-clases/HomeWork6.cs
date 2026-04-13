partial class Program
{
    static void Employees()
    {
        // 6. Instanciar una lista de empleados con al menos los siguientes datos:
        //    - Carlos (Team Leader, 5000)
        //    - Ana (Developer, 4000)
        //    - Laura (Team Leader, 6000)
        //    - Luis (Developer, 3500)
        var employees = new List<Employee>
        {
            new TeamLeader("Carlos", 5_000),
            new Developer("Ana", 4_000),
            new TeamLeader("Laura", 6_000),
            new Developer("Luis", 3_500)
        };

        WriteLine("Detalles de Empleados: ");
        // 7. Recorrer la lista de empleados y mostrar la información de cada uno con el método "ShowInfo()".
        foreach (var employee in employees)
        {
            employee.ShowInfo();
        }
    }

    // 1. Crear una clase base "Employee" con las siguientes propiedades protegidas:
    //    - Name (string)
    //    - Salary (double)
    //    - Position (string)
    class Employee
    {
        protected string? Name { get; set; }
        protected double Salary { get; set; }
        protected string? Position { get; set; }
        // 2. Implementar un constructor en "Employee" que inicialice sus valores.
        public Employee(string name, double salary, string position)
        {
            Name = name;
            Salary = salary;
            Position = position;
        }
        // 3. Agregar un método virtual "CalculateBonus()" que retorne un bono del 5% del salario.
        public virtual double CalculateBonus()
        {
            return Salary * 0.05;
        }
        // 4. Agregar un método "ShowInfo()" que muestre los detalles del empleado:
        //    - Nombre
        //    - Cargo
        //    - Salario
        //    - Bono calculado
        public void ShowInfo()
        {
            WriteLine($"Empleado: {Name}, Cargo: {Position}, Salario: {Salary:C}, Bono: {CalculateBonus():C}");
        }
    }

    // 5. Crear dos clases derivadas de "Employee":
    //    - "TeamLeader": Su bono es del 10% del salario.
    //    - "Developer": Su bono es del 7% del salario.

    class TeamLeader : Employee
    {
        public TeamLeader(string name, double salary) : base(name, salary, "Team Leader")
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.10;
        }
    }

    class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary, "Developer")
        {
        }

        public override double CalculateBonus()
        {
            return Salary * 0.07;
        }
    }
}