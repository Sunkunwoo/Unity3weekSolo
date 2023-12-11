using TMPro;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public TextMeshProUGUI popup_UiTxt;
    public GameObject slots;

    void Start()
    {
        popup_UiTxt.text = $"Using item? {slots.GetComponent<InventorySlot>().item_Name.text}";
    }
}
