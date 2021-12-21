using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace part2
{
    public class Station : IComparer<Train>
    {
        private List<Train> trains;

        public Station(List<Train> trains)
        {
            this.trains = trains;
        }
        public Station(){}

        public string FindRaceByIndex(string index)
        {
            if (index.Length != 4)
                throw new LengthOfRaceException("номер рейса не четырёхзначный");
            foreach (var item in trains)
            {
                if (item.Idpoezda == index)
                    return item.ToString();
            }
            throw new RaceDoesNotExistsException("Такого рейса нет");
        }

        public string FindRacesAfterNecessaryDateTime(DateTime dt)
        {
            string str = "";
            foreach (var item in trains)
            {
                if (item.Vrotpravleniya > dt)
                    str += item.ToString() + "\n";
            }

            if (str != "")
                return str;
            else
                throw new RacesDontExistAfterNecessaryDateTime("Нет рейсов после введённого времени");

        }

        public string FindRacesByNecessaryDestination(string destination)
        {
            if (destination == String.Empty)
                throw new ArgumentException("Место назначения не может быть пустым");
            string str = "";
            foreach (var item in trains)
            {
                if (item.Punktnaznach == destination)
                    str += item.ToString() + "\n";
            }

            if (str != "")
                return str;
            else
                throw new RacesDontExistAfterInputDestination(
                    "Нет рейсов, отправляющихся в необходимый пункт назначения");
        }

        public int Compare(Train t1, Train t2)
        {
            if (t1.Vrotpravleniya > t2.Vrotpravleniya)
                return 1;
            else if (t1.Vrotpravleniya < t2.Vrotpravleniya)
                return -1;
            else
                return 0;
        }
    }
}