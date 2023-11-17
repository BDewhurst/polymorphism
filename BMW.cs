namespace Polymorphism {
    class Bmw: Car {

        private string Brand = "BMW";
        public string Model {get; set;}
        public Bmw (string color, int hp, string model ) : base ( color, hp) {
        
         this.Model = model; 
          
        }

        public new void ShowDetails() {
            Console.WriteLine($"It's a {Brand}  and the colour of the car is {Color} and the HP is {HP} and the model is ${Model}");
        }

        public override void Repair() {
            Console.WriteLine($"The {Brand} was repaired!");
        }
    }
}