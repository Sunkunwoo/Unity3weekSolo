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
    public bool CheckEQ;

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

    public void UseItem()
    {
        if (itemType == ItemType.Potion)
        {
            if (itemQuantity != 0)
            {
                itemQuantity--;
                Debug.Log($"Used Potion! Remaining Quantity: {itemQuantity}");
            }
            else
            {
                Debug.Log($"{itemName} Item Count : 0");
            }
        }
        else
        {
            if (itemQuantity != 0)
            {
                Debug.Log($"Used {itemName}");
            }
            else
            {
                Debug.Log($"Can not Used {itemName}");
            }
        }
    }
}
