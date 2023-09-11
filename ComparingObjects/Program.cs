internal class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee("Jack", "Runner", 34.40));
        employees.Add(new Employee("Shin", "Kaname", 67.88));
        employees.Add(new Employee("Gant", "Runner", 54.55));
        employees.Add(new Employee("Thabo", "Nkosi", 54.00));
        employees.Add(new Employee("Lebo", "Kat", 54.00));
        employees.Add(new Employee("Ken", "Pard", 34.11));
        employees.Add(new Employee("Ain", "Kaname", 67.88));
        employees.Add(new Employee("Caller", "1ne", 56.44));
        employees.Add(new Employee("Leo", "Pard", 77.88));
        employees.Add(new Employee("Ain", "Kaname", 67.88));
        employees.Add(new Employee("Next", "Palyer", 67.88));
        employees.Add(new Employee("Ben", "1ne", 67.88));
        employees.Add(new Employee("Jack", "Runner", 34.40));



        //Display(employees);

        BubbleSort(employees);
    }

    private static void Display(List<Employee> list)
    {
        foreach (Employee e in list)
        {
            Console.Write(e.ToString());
            Console.WriteLine();
        }
    }

    private static void BubbleSort(List<Employee> list)
    {


        Display(list);
        Console.WriteLine();
        for (int y = 0; y < list.Count - 1; y++)
        {
            for (int i = (y + 1); i < list.Count; i++)
            {
                if (list[y].CompareTo(list[i]) > 0)
                {
                    Employee temp = list[i];
                    list[i] = list[y];
                    list[y] = temp;
                }

                //if (String.Compare(list[i].LastName, list[y].LastName) < 0)
                //{
                //    Employee temp = list[i];
                //    list[i] = list[y];
                //    list[y] = temp;
                //}

                //if (String.Compare(list[i].LastName, list[y].LastName) == 0)
                //{
                //    Employee temp = list[i];
                //    list[i] = list[y];
                //    list[y] = temp;
                //}

            }
        }


        Display(list);
    }
}



public class Employee : IComparable<Employee>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public double? Salary { get; set; }


    public Employee(string firstname, string lastname, double salary) => (FirstName, LastName, Salary) = (firstname, lastname, salary);

    public override string ToString()
    {
        string str = LastName.Substring(0, 3);
        return $"{FirstName} {str.ToUpper()}. : R {Salary}";
    }

    public int CompareTo(Employee? other)
    {
        int results = this.LastName.CompareTo(other.LastName);

        if (results == 0)
        {
            results = this.FirstName.CompareTo(other?.FirstName);
        }
        return results;
    }
}
