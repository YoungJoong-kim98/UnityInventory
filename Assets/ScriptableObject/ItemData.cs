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
    [Header("�⺻ ����")]
    public Sprite icon;
    public string itemName;
    public int id;
    public ItemType itemType;

    [Header("���� ����ġ (��� ������ ����)")]
    public int addAttackPower;
    public int addDefensePower;
    public int addHealth;
    public int addCritical;
}
