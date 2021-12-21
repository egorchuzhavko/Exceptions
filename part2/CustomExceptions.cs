using System;

namespace part2
{
    class LengthOfRaceException : Exception
    {
        public LengthOfRaceException(string? message) : base(message)
        {
        }
    }

    class RaceDoesNotExistsException : Exception
    {
        public RaceDoesNotExistsException(string? message) : base(message)
        {
        }
    }

    class RacesDontExistAfterNecessaryDateTime : Exception
    {
        public RacesDontExistAfterNecessaryDateTime(string? message) : base(message)
        {
        }
    }

    class RacesDontExistAfterInputDestination : Exception
    {
        public RacesDontExistAfterInputDestination(string? message) : base(message)
        {
        }
    }
}