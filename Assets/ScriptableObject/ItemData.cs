using System;
using UnityEngine;

public enum ItemType
{
    Equipable,
    Consumable,
    Resource
}

[CreateAssetMenu(fileName = "Item", menuName = "New Item")]
public class ItemData : ScriptableObject
{
    [Header("기본 정보")]
    public Sprite icon;
    public string itemName;
    public int id;
    public int count;
    public ItemType itemType;

    [Header("스탯 증가치 (장비 아이템 전용)")]
    public int addAttackPower;
    public int addDefensePower;
    public int addHealth;
    public int addCritical;
}
