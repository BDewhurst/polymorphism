namespace Polymorphism
{
    class Audi : Car
    {

        public string Model { get; set; }
        private string Brand = "Audi";
        public Audi(string color, int hp, string model) : base(color, hp)
        {

            Model = model;
        }

        public void ShowDetails()
        {
            Console.WriteLine($"The colour of the car is {Color} and the HP is {HP}");
        }

        public override void Repair()
        {
            Console.WriteLine($"The {Brand} was repaired!");
        }
    }
}