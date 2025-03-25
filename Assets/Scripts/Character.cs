using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string Name { get; private set; }
    public int Lv { get; private set; }
    public int AttackPower { get; private set; }
    public int DefensePower { get; private set; }
    public int CurrentEXP { get; private set; }
    public int MaxExp { get; private set; }
    public int Gold { get; private set; }
    public int Health { get; private set; }
    public int Critical { get; private set; }

    public List<InventoryItem> Inventory { get; private set; } = new();
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

    public void AddItem(InventoryItem item)
    {
        Inventory.Add(item);
    }

    public void Equip(InventoryItem item)
    {
        if (item.isEquipped || item.itemData.itemType != ItemType.Equipable) return;

        AttackPower += item.itemData.addAttackPower;
        DefensePower += item.itemData.addDefensePower;
        Health += item.itemData.addHealth;
        Critical += item.itemData.addCritical;

        item.isEquipped = true;
    }

    public void UnEquip(InventoryItem item)
    {
        if (!item.isEquipped) return;

        AttackPower -= item.itemData.addAttackPower;
        DefensePower -= item.itemData.addDefensePower;
        Health -= item.itemData.addHealth;
        Critical -= item.itemData.addCritical;

        item.isEquipped = false;
    }
}
