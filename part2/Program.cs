﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

namespace part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var train1 = new Train("Будапешт", "twn1", 
                new DateTime(2021, 12, 25, 12, 00, 00));
            var train3 = new Train("Будапешт", "twn2", 
                new DateTime(2021, 12, 25, 12, 30, 00));
            var train4 = new Train("Будапешт", "twn1", 
                new DateTime(2021, 12, 25, 10, 00, 00));
            var train5 = new Train("Минск", "twn1", 
                new DateTime(2021, 12, 26, 11, 00, 00));
            var train2 = new Train("Минск", "twn2", 
                new DateTime(2021, 12, 26, 12, 30, 00));
            var train6 = new Train("Минск", "twn3", 
                new DateTime(2021, 12, 26, 13, 15, 00));

            List<Train> trains = new List<Train> {train1, train3, train4, train2, train5, train6};

            var station = new Station(trains);

            try
            {
                Console.WriteLine("Введите айди рейса для поиска рейсов: ");
                string id = Console.ReadLine();
                Console.WriteLine("\n" + station.FindRaceByIndex(id) + "\n");
                Console.WriteLine("Введите дату для поиска рейсов после введённой даты: ");
                var dt = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\n"+station.FindRacesAfterNecessaryDateTime(dt)+"\n");
                
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (LengthOfRaceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (RaceDoesNotExistsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (RacesDontExistAfterNecessaryDateTime ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (RacesDontExistAfterInputDestination ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}