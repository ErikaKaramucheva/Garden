
using System;
using System.Collections.Generic;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            string plant;
            double number;
            
            List<string> items = new List<string>();
           
            while (true)
            {
                Console.WriteLine("Въведете вид растение:");
                plant = Console.ReadLine();
                if(plant=="End"|| plant == "end")
                {
                    break;
                }
                Console.WriteLine("Въведете брой: ");
                number = double.Parse(Console.ReadLine());
                
                for (int i = 0; i < number; i++)
                {
                    items.Add(plant);
                   // Console.WriteLine(plant + "   " + number);
                }
                
            }

            CalculateResult(items);
        }

        public static void CalculateResult(List<string> items)
        {
            //InitializeItems
            Peach peach = new Peach();
            Apricot apricot = new Apricot();
            Acacia acacia = new Acacia();
            Oak oak = new Oak();
            Lily lily = new Lily();
            Rose rose = new Rose();
            Carrot carrot = new Carrot();
            Strawberry strawberry = new Strawberry();

            //var for result
            double waterRequired = 0;
            double energy = 0;
            double beautyScore = 0;

            foreach (var gardenItems in items)
            {
                
                    switch (gardenItems) {
                        case "Peach":
                    case "peach":
                            waterRequired = waterRequired + peach.WaterRequired();
                            energy += peach.Energy();
                            break;
                        case "Apricot":
                    case "apricot":
                            waterRequired += apricot.WaterRequired();
                            energy += apricot.Energy();
                            break;
                    case "Acacia":
                    case "acacia":
                        waterRequired += acacia.WaterRequired();
                        beautyScore += acacia.BeautyScore();
                        break;
                    case "Oak":
                    case "oak":
                        waterRequired += oak.WaterRequired();
                        beautyScore += oak.BeautyScore();
                        break;
                    case "Lily":
                    case "lily":
                        waterRequired += lily.WaterRequired();
                        beautyScore += lily.BeautyScore();
                        break;
                    case "Rose":
                    case "rose":
                        waterRequired += rose.WaterRequired();
                        beautyScore += rose.BeautyScore();
                        break;
                    case "Carrot":
                    case "carrot":
                        waterRequired += carrot.WaterRequired();
                        energy += carrot.Energy();
                        break;
                        case "Strawberry":
                        waterRequired += strawberry.WaterRequired();
                        energy += strawberry.Energy();
                        break;
                }

            }
            Console.WriteLine("WaterRequired: " + waterRequired);
            Console.WriteLine("Energy: " + energy);
            Console.WriteLine("BeautyScore: " + beautyScore);
           


        }

    }
}
