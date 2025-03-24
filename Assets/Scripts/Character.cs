using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string Name;
    public int Lv;
    public int AttackPower;
    public int DefensePower;
    public int CurrentEXP;
    public int MaxExp;
    public int Gold;
    public int Health;
    public int Critical;

    public Character(string name, int lv, int attackPower, int defensePower, int currentEXP, int maxExp, int gold, int health, int critical)
    {
        Name = name;
        Lv = lv;
        AttackPower = attackPower;
        DefensePower = defensePower;
        CurrentEXP = currentEXP;
        MaxExp = maxExp;
        Gold = gold;
        Health = health;
        Critical = critical;
    }
}
