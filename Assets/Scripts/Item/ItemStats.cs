using System;
    public enum ItemType
    {
        Weapon,
        Armor,
        Accessory,
        potion,
    }

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

        }