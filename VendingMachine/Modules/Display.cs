﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Modules
{
    public class Display
    {
        public static void ShowDrinks(List<Dictionary<DrinkCode, int>> stock)
        {
            foreach (Dictionary<DrinkCode, int> row in stock)
            {
                Console.WriteLine("------------------------------------------------------------------");
                foreach (KeyValuePair<DrinkCode, int> k in row)
                {
                    Console.Write("|" + k.Key.Code + "| " + k.Key.drink.GetType().Name + " : " + k.Value + " left, price: " + k.Key.drink.Price + " dollars\t\t");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
        }

        public static void MoneyInserted(MoneyCollector m)
        {
            Console.WriteLine("You already inserted " + m.TotalMoneyInDouble + " dollar :");
            Console.WriteLine(m.Show());
        }

        public static void Insert(MoneyCollector m)
        {
            string choice;

            Console.WriteLine("Which coin do you want to insert ?");
            Console.WriteLine("\t1 : 2 dollar");
            Console.WriteLine("\t2 : 1 dollar");
            Console.WriteLine("\t3 : 50 cents");
            Console.WriteLine("\t4 : 20 cents");
            Console.WriteLine("\t5 : 5 dollar");
            Console.WriteLine("\t9 : Exit");

            do
            {
                MoneyInserted(m);
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        m.Insert(Money.TwoDollar);
                        break;
                    case "2":
                        m.Insert(Money.OneDollar);
                        break;
                    case "3":
                        m.Insert(Money.FiftyCent);
                        break;
                    case "4":
                        m.Insert(Money.TwenyCent);
                        break;
                    case "5":
                        m.Insert(Money.FiveDollar);
                        break;
                    default:
                        break;
                }
            } while (choice != "9");
        }

        public void Run()
        {
            bool test = false;
            bool leave = false;
            int drinkPrice = 0;

            do
            {
                ShowDrinks(Distributor.Stock);
                Insert(Distributor.Collector);
                ShowDrinks(Distributor.Stock);

                do
                {
                    Console.WriteLine("Choose your drink using the code.");
                    string code = Console.ReadLine();
                    DrinkCode drinkCode = new DrinkCode();



                    bool predicate(DrinkCode x) => x.Code.ToString() == code;

                    foreach (Dictionary<DrinkCode, int> row in Distributor.Stock)
                    {
                        if (Array.Find(row.Keys.ToArray(), predicate) != null)
                        {
                            drinkCode = Array.Find(row.Keys.ToArray(), predicate);
                        }
                    }



                    Dictionary<DrinkCode, int> rowDrink = Distributor.Stock.Find(x => x.Keys.Contains(drinkCode));

                    if (drinkCode.drink == null)
                    {
                        Console.WriteLine("Wrong code");
                    }
                    else if (rowDrink[drinkCode] == 0)
                    {
                        Console.WriteLine("No more stock for this drink, try an other\n");
                    }
                    else
                    {
                        while (Distributor.Collector.TotalMoneyInDouble < drinkCode.drink.Price)
                        {
                            Console.WriteLine("You inserted " + Distributor.Collector.TotalMoneyInDouble + " euros and the price for this product is " + drinkCode.drink.Price + " euros, you have to insert more !\n");
                            Insert(Distributor.Collector);
                        }

                        Console.WriteLine("You have received 1 " + drinkCode.drink.GetType().Name + "\n");
                        rowDrink[drinkCode]--;
                        drinkPrice = Convert.ToInt32(drinkCode.drink.Price * 100);
                        test = true;
                    }
                } while (!test);

                Dictionary<Money, int> moneyReturned = Distributor.Collector.GetChange(drinkPrice);
                ShowMoneyReturned(moneyReturned, drinkPrice);
                Distributor.ResetMoneyCollector();

                Console.WriteLine("\nLeave ?");
                Console.WriteLine("\t1. Yes");
                Console.WriteLine("\t2. No");

                leave = Console.ReadLine() == "1";

            } while (!leave);
        }

        public static void ShowMoneyReturned(Dictionary<Money, int> change, int drinkPrice)
        {
            double money = (double)(Distributor.Collector.TotalMoney - drinkPrice) / 100;
            Console.WriteLine("The machine gave you back " + money + " :");
            foreach (KeyValuePair<Money, int> coins in change)
            {
                string test = CoinInString(coins.Key);
                Console.WriteLine("\t- " + coins.Value + " time " + test);

            }
        }

        public static string CoinInString(Money coin)
        {
            string coinInString = "";
            switch (coin)
            {
                case Money.FiveDollar:
                    coinInString = "5 dollar";
                    break;
                case Money.TwoDollar:
                    coinInString = "2 dollar";
                    break;
                case Money.OneDollar:
                    coinInString = "1 dollar";
                    break;
                case Money.FiftyCent:
                    coinInString = "50 cents";
                    break;
                case Money.TwenyCent:
                    coinInString = "20 cents";
                    break;
            }
            return coinInString;
        }
    }
}
