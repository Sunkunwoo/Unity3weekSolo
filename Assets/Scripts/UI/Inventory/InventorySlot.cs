using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image eq_Icon;
    public Image icon;

    public TextMeshProUGUI item_Name;
    public TextMeshProUGUI item_Count;


    public GameObject eqPopUp;

    public bool checkEq = false;

    private ItemStats currentItem;
    PlayerInfo playerInfo;

    private void Start()
    {
        playerInfo = GameObject.Find("Player").GetComponent<PlayerInfo>();
    }

    public void Additem(ItemStats _item)
    {
        currentItem = _item;
        icon.sprite = _item.itemIcon;
        item_Name.text = _item.itemName;
        item_Count.text = _item.itemQuantity.ToString();
    }

    public void RemoveItem()
    {
        currentItem = null;
        icon.sprite = null;
        item_Count.text = "";
        item_Name.text = "";
    }

    public void UseItem()
    {
        if (currentItem != null)
        {
            if (currentItem.itemType == ItemStats.ItemType.Potion)
            {
                currentItem.UseItem();
                UpdateItemCount();
                playerInfo.CurrentStats.maxHp += currentItem.healthBonus;
                eqPopUp.gameObject.SetActive(false);
            }
            else
            {
                EquipItem();
            }
        }
    }

    public void OpenPopUpEq()
    {
        eqPopUp.gameObject.SetActive(true);
    }

    public void ClosePopUpEq()
    {
        eqPopUp.gameObject.SetActive(false);
    }

    private void UpdateItemCount()
    {
        if (currentItem != null)
        {
            item_Count.text = currentItem.itemQuantity.ToString();
        }
    }

    public void EquipItem()
    {
        if (currentItem.itemQuantity != 0)
        {
            if (checkEq == false)
            {
                checkEq = true;
                eq_Icon.gameObject.SetActive(true);
                playerInfo.CurrentStats.atk += currentItem.damage;
                playerInfo.CurrentStats.def += currentItem.defense;
                Debug.Log($"Equipped {currentItem.itemName}");
                eqPopUp.gameObject.SetActive(false);
            }
            else
            {
                checkEq = false;
                eq_Icon.gameObject.SetActive(false);
                playerInfo.CurrentStats.atk -= currentItem.damage;
                playerInfo.CurrentStats.def -= currentItem.defense;
                Debug.Log($"UnEquipped {currentItem.itemName}");
                eqPopUp.gameObject.SetActive(false);
            }
        }
        else
        {
            Debug.Log($"Can't Use {currentItem.itemName}");
            eqPopUp.gameObject.SetActive(false);
        }
    }
}
