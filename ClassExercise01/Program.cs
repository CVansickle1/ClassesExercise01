using ClassExercise01;

Console.WriteLine("Please enter the Make, Model, and Year of your Vehicle: ");
Car yourCar = new Car()
{
    Make = GettingInput.GetStringInput(1),
    Model = GettingInput.GetStringInput(2),
    Year = GettingInput.GetYear(),
};

yourCar.PrintCarInfo();







