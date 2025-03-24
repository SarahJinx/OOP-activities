namespace OOP
{
    internal class Eevee
    {
        // Class attributes
        public string Name { get; set; }
        public string Type { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        // Constructor
        public Eevee(string name, string type, int hp, int attack, int defense, int speed)
        {
            Name = name;
            Type = type;
            HP = hp;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }

        // Method to make a characteristic sound
        public virtual string MakeSound()
        {
            return Name switch
            {
                "Glaceon" => "Glay Glay!",
                "Vaporeon" => "Vaaapoo!",
                "Sylveon" => "Sylvii! Sylv!",
                "Umbreon" => "Umbre Umb!",
                "Espeon" => "Espii Esp!",
                "Leafeon" => "Leaf Leaf!",
                "Flareon" => "Flaaare!",
                "Jolteon" => "Jol! Jolteon!",
                "Eevee" => "Vee Vee!",
                _ => "!Unknown!"
            };
        }
    }

    class BaseEevee : Eevee
    {
        public BaseEevee() : base("Eevee", "Normal", 55, 55, 50, 55) { }
    }

    class Vaporeon : Eevee
    {
        public Vaporeon() : base("Vaporeon", "Water", 130, 65, 60, 60) { }
    }

    class Jolteon : Eevee
    {
        public Jolteon() : base("Jolteon", "Electric", 65, 65, 60, 130) { }
    }

    class Flareon : Eevee
    {
        public Flareon() : base("Flareon", "Fire", 65, 95, 60, 65) { }
    }

    class Espeon : Eevee
    {
        public Espeon() : base("Espeon", "Psychic", 65, 65, 60, 110) { }
    }

    class Umbreon : Eevee
    {
        public Umbreon() : base("Umbreon", "Dark", 95, 65, 110, 65) { }
    }

    class Leafeon : Eevee
    {
        public Leafeon() : base("Leafeon", "Grass", 65, 110, 60, 95) { }
    }

    class Glaceon : Eevee
    {
        public Glaceon() : base("Glaceon", "Ice", 65, 60, 110, 65) { }
    }

    class Sylveon : Eevee
    {
        public Sylveon() : base("Sylveon", "Fairy", 95, 65, 65, 60) { }
    }
}
