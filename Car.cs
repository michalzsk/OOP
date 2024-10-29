namespace Exercise_solution
{
    public class Car
    {
        public string Model { get; set; }
        public string Name { get; set; }
        public int ProductionDate { get; set; }
        public Car(string model, string name, int productionDate)
        {
            Model = model;
            Name = name;
            ProductionDate = productionDate;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(Model);
            Console.WriteLine(Name);
            Console.WriteLine(ProductionDate);
        }

    }

}