﻿using System;

public class Knight
{
    private string faction;
    private string name;

    private int abilityPoints;
    private int healthPoints;
    private int level;

    private ChainLink bodyArmor;
    private Hammer weapon;

    public string Faction
    {
        get
        {
            return this.faction;
        }
        set
        {
            if (value == "Melee" || value == "Spellcaster")
            {
                this.faction = value;
            }
            else
            {
                this.faction = "Melee";
                Console.WriteLine("Please choose \"Melee\" or \"Spellcaster\"");
            }
        }
    }
    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            if (value.Length >= 2 && value.Length <= 10)
            {
                this.name = value;
            }
            else
            {
                this.name = "No name";
                Console.WriteLine("Name must be between 2 and 10 characters in length.");
            }

        }
    }

    public int AbilityPoints
    {
        get
        {
            return this.abilityPoints;
        }
        set
        {
            if (value >= 0 && value < 12)
            {
                this.abilityPoints = value;
            }
            else
            {
                this.abilityPoints = 0;
                Console.WriteLine("Ability points cannot be negative or greater than 12!");
            }

        }
    }
    public int HealthPoints
    {
        get
        {
            return this.healthPoints;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                this.healthPoints = level;
            }
            else
            {
                this.healthPoints = 1;
                Console.WriteLine("Health cannot be negative or greater than 100!");
            }
        }
    }
    public int Level
    {
        get
        {
            return this.level;
        }
        set
        {
            if (value >= 1 && value <= 100)
            {
                this.level = value;
            }
            else
            {
                Console.WriteLine("Level must be between 1 and 100!  Level set to 1.");
                this.level = 1;
            }
        }
    }
    public ChainLink BodyArmor
    {
        get
        {
            return this.bodyArmor;
        }
        set
        {
            this.bodyArmor = value;
        }
    }
    public Hammer Weapon
    {
        get
        {
            return this.weapon;
        }
        set
        {
            this.weapon = value;
        }
    }
    public Knight()
        : this("KBob", 1)
    {
    }

    public Knight(string name, int level)
        : this(name, level, 10)
    {
    }

    public Knight(string name, int level, int healthPoints)
    {
        this.Name = name;
        this.Level = level;
        this.HealthPoints = healthPoints;
        this.Faction = "Melee";
        this.AbilityPoints = 10;
        this.BodyArmor = new ChainLink();
        this.Weapon = new Hammer();
    }

    public void HolyBlow()
    {
        throw new NotImplementedException();
    }

    public void PurifySoul()
    {
        throw new NotImplementedException();
    }

    public void RighteousWings()
    {
        throw new NotImplementedException();
    }
}

