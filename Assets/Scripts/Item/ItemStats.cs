using System;
using UnityEngine;

[Serializable]
public class ItemStats
{
    public int index;
    public string itemName;
    public int itemValue;
    public int itemQuantity;
    public int damage;
    public int defense;
    public int healthBonus;
    public ItemType itemType;
    public Sprite itemIcon;

    public enum ItemType
    {
        Weapon,
        Armor,
        Accessory,
        Potion,
    }
    public ItemStats(int _index, string _itemName, int _itemValue, int _itemQuantity, int _damage, int _defense, int _healthBonus, ItemType _itemType, Sprite _itemIcon)
    {
        index = _index;
        itemName = _itemName;
        itemValue = _itemValue;
        itemQuantity = _itemQuantity;
        damage = _damage;
        defense = _defense;
        healthBonus = _healthBonus;
        itemType = _itemType;
        //itemIcon = Resources.Load<Sprite>("ItemIcon/" + _index.ToString());
    }
}
