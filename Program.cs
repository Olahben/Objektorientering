// make a program to demonstrate the foundational principals of object oriented programming
// use inheritance, encapsulation, and polymorphism
// Make a system for a zoo where different types of animals can be handled through a common system
// Different animal types can be registered, and actions about each animal type should be able to be performed

// How to go forward:
// Make a class for the zoo that includes basic actions and methods for the zooo
// This includes: adding animals, removing animals, feeding animals, and displaying all animals
// This will of course need fields storing this data, and methods to interact with the data
// Make a class for the animals that includes basic actions and methods for the animals
// This includes: eating, sleeping, and making noise, displaying age, species, and gender
// This will of course need fields storing this data, and methods to interact with the data
// Specific actions is going to be stored in an interface for the specific animal types


using System;
using System.Collections.Generic;

// Is used to store the animals
public class Zoo
{
    // Demonstrates polymorphism, as any subclass inheriting from Animal can be stored in the list
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        animals.Remove(animal);
    }

    public void FeedAnimals()
    {
        foreach (Animal animal in animals)
        {
            animal.Eat();
        }
    }

    public void DisplayBasicInformation()
    {
        foreach (Animal animal in animals)
        {
            Console.WriteLine("Age: " + animal.Age);
            Console.WriteLine("Species: " + animal.Species);
            Console.WriteLine("Gender:" + animal.Gender);
        }
    }
}

public class Animal
{
    // Fields
    public double Age { get; protected set; }
    public string Species { get; protected set; }
    public string Gender { get; protected set; }
    // Virtual methods can be overridden by child classes
    virtual public void Eat()
    {
        Console.WriteLine("The animal is eating");
    }
    virtual public void Sleep()
    {
        Console.WriteLine("The animal is sleeping");
    }

    virtual public void MakeNoise()
    {
        Console.WriteLine("The animal is making noise");
    }
}

// Inherits from the animal class
public class Lion : Animal
{
    // Fields
    private string name;
    private string color;
    private int weight;
    private int height;
    private bool sleepsAlot = true;
    private bool isDangerous = true;

    // Constructor
    public Lion(string name, string color, int weight, int height, double age, string species, string gender)
    {
        this.name = name;
        this.color = color;
        this.weight = weight;
        this.height = height;

        this.Age = age;
        this.Species = species;
        this.Gender = gender;
    }

    // Methods
    public void Roar()
    {
        Console.WriteLine("The lion is roaring");
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Age: " + this.Age);
        Console.WriteLine("Species: " + this.Species);
        Console.WriteLine("Gender: " + this.Gender);
        Console.WriteLine("Is dangerous: " + isDangerous);
        Console.WriteLine("Sleeps alot: " + sleepsAlot);
    }
}

public class Elephant : Animal
{
    // Fields
    private string name;
    private string color;
    private int weight;
    private int height;
    private bool isHeavy = true;

    // Constructor
    public Elephant(string name, string color, int weight, int height, double age, string species, string gender)
    {
        this.name = name;
        this.color = color;
        this.weight = weight;
        this.height = height;

        this.Age = age;
        this.Species = species;
        this.Gender= gender;
    }

    // Methods
    public void Trumpet()
    {
        Console.WriteLine("The elephant is trumpeting");
    }

    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Weight: " + weight);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Age: " + this.Age);
        Console.WriteLine("Species: " + this.Species);
        Console.WriteLine("Gender" + this.Gender);
        Console.WriteLine("Is heavy: " + isHeavy);
    }
}

// add main method
class Program
{
    static void Main()
    {
        // Create a zoo
        Zoo zoo = new Zoo();

        Lion lion = new Lion("Simba", "Yellow", 200, 100, 5, "Lion", "Male");
        Elephant elephant = new Elephant("Dumbo", "Grey", 500, 300, 10, "Elephant", "Male");

        zoo.AddAnimal(lion);
        zoo.AddAnimal(elephant);

        zoo.FeedAnimals();
        zoo.DisplayBasicInformation();
    }
}