using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private InventorySlot[] slots;

    private List<ItemStats> inventoryItemList;

    public Transform tf;


    // Start is called before the first frame update
    void Start()
    {
        inventoryItemList = ItemManager.Instance.items;
        slots = tf.GetComponentsInChildren<InventorySlot>();
        InitializeInventoryUI();
    }

    void InitializeInventoryUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventoryItemList.Count)
            {
                slots[i].Additem(inventoryItemList[i]);
            }
            else
            {
                slots[i].RemoveItem();
            }
        }
    }
}
