using System;

namespace NFL2021.Model
{
    public class FootBallPlayer
    {
        private string _name;
        private int _price;
        private int _shirtNumber;

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }
        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if (value < 1 || value > 100) throw new ArgumentOutOfRangeException();
                _shirtNumber = value;
            }
        }

        public FootBallPlayer()
        {

        }

        public FootBallPlayer(int id, string name, int price, int shirtNumber)
        {
            Id = id;
            Name = name;
            Price = price;
            ShirtNumber = shirtNumber;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Price)}: {Price}, {nameof(ShirtNumber)}: {ShirtNumber}";
        }
    }
}