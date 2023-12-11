using TMPro;
using UnityEngine;

public class PopUp : MonoBehaviour
{
    public TextMeshProUGUI popup_UiTxt;
    public GameObject slots;
    private void Start()
    {
        Vector3 localPosition = transform.position - transform.parent.position;

        // 게임 화면 중앙으로 이동
        Vector3 centerPosition = new Vector3(Screen.width /2, Screen.height*0.8f, 0);
        transform.position = centerPosition + localPosition;
    }

    void Update()
    {
        if (slots.GetComponent<InventorySlot>().checkEq != true)
        {
            popup_UiTxt.text = $"Using item? {slots.GetComponent<InventorySlot>().item_Name.text}";
        }
        else
        {
            popup_UiTxt.text = $"Un Using item? {slots.GetComponent<InventorySlot>().item_Name.text}";
        }
    }
}
