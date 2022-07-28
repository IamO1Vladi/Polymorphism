using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.IO.Interfaces;
using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Bird;
using WildFarm.Models.Animals.Mammal;
using WildFarm.Models.Animals.Mammal.Feline;
using WildFarm.Models.Food;

namespace WildFarm.Core
{
    internal class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWritter writer;

        public Engine(IReader reader, IWritter writer)
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            List<Animal> animals = new List<Animal>();
            List<Food> foods = new List<Food>();
            int lineNumber = 1;
            string[] cmdArg = {};
            while (true)
            {

                if (lineNumber % 2 !=0)
                {
                     cmdArg = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (cmdArg[0] == "End")
                    {
                        break;
                    }
                    string type = cmdArg[0];
                    string name = cmdArg[1];
                    double weight = double.Parse(cmdArg[2]);
                    string livingRegion = string.Empty;
                    string breed = string.Empty;
                    double wingsize;
                    Animal newAnimal;
                    switch (type)
                    {
                        //Felines -> "{Type} {Name} {Weight} {LivingRegion} {Breed}"
                        case "Cat":
                            livingRegion = cmdArg[3];
                            breed= cmdArg[4];
                             newAnimal=new Cat(name,weight,0,livingRegion,breed);
                            animals.Add(newAnimal);

                            break;
                        case "Tiger":
                             livingRegion = cmdArg[3];
                            breed = cmdArg[4];
                            newAnimal = new Tiger(name, weight, 0, livingRegion, breed);
                            animals.Add(newAnimal);
                            break;

                        //Birds->"{Type} {Name} {Weight} {WingSize}"

                        case "Owl":
                            wingsize = double.Parse(cmdArg[3]);
                            newAnimal = new Owl(name, weight, 0, wingsize);
                            animals.Add(newAnimal);
                            break;
                        case "Hen":
                            wingsize = double.Parse(cmdArg[3]);
                            newAnimal = new Hen(name, weight, 0, wingsize);
                            animals.Add(newAnimal);
                            break;

                        /*Mice and Dogs - "{Type} {Name} {Weight} {LivingRegion}"*/

                        case "Mouse":

                            livingRegion = cmdArg[3];
                            newAnimal=new Mouse(name,weight,0,livingRegion);
                            animals.Add(newAnimal);
                            break;
                        case "Dog":
                             livingRegion = cmdArg[3];
                            newAnimal = new Dog(name, weight, 0, livingRegion);
                            animals.Add(newAnimal);

                            break;

                        default:
                            break;
                    }
                    
                        writer.WriteLine(animals[animals.Count - 1].ProduceSound());
                    
                }
                else
                {
                     cmdArg = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    //Food types:
                    //	Vegetable
                    //	Fruit
                    //	Meat
                    //	Seeds

                    string foodType = cmdArg[0];
                    int quntity = int.Parse(cmdArg[1]);
                    Food newFood;
                    switch (foodType)
                    {
                        case "Vegetable":
                            newFood = new Vegetable(quntity);
                            foods.Add(newFood);
                            break;
                        case "Fruit":
                            newFood = new Fruit(quntity);
                            foods.Add(newFood);
                            break;
                        case "Meat":
                            newFood = new Meat(quntity);
                            foods.Add(newFood);
                            break;
                        case "Seeds":
                            newFood = new Seeds(quntity);
                            foods.Add(newFood);
                            break;

                        default:
                            break;
                    }

                }

                if (lineNumber %2==0)
                {
                    Animal curentAnimal = animals[animals.Count - 1];
                    Food currentFood = foods[foods.Count - 1];
                    

                    if (IsEatable(curentAnimal.GetType().Name, currentFood.GetType().Name))
                    {
                        curentAnimal.Eat(currentFood.Quantity);
                    }
                    else
                    {
                        writer.WriteLine($"{curentAnimal.GetType().Name} does not eat {currentFood.GetType().Name}!");
                    }
                }

                

                lineNumber++;
            }


            foreach (var animal in animals)
            {
                writer.WriteLine(animal.ToString());
            }

        }

        private bool IsEatable(string animalType,string foodType)
        {

//•Hens eat everything
//•	Mice eat vegetables and fruits
//•	Cats eat vegetables and meat
//•	Tigers, Dogs, and Owls eat only meat


            switch (animalType)
            {
                case "Mouse":
                    if(foodType !="Vegetable" && foodType != "Fruit")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                   
                case "Cat":
                    if (foodType != "Vegetable" && foodType != "Meat")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                   
                default:
                    if (animalType != "Hen")
                    {
                        if (foodType == "Meat")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return true;
                    }
                   
            }

        }
    }
}
