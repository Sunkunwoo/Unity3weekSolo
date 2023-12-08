using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBtn : MonoBehaviour
{
    public GameObject btnList;
    public GameObject statusUI;
    public GameObject inventoryUI;

    public void OpenStatusUi()
    {
        btnList.SetActive(false);
        statusUI.SetActive(true);
    }
    public void OpenInventoryUI()
    {
        btnList.SetActive(false);
        inventoryUI.SetActive(true);
    }
    public void BackUi()
    {
        btnList.SetActive(true);
        inventoryUI.SetActive(false);
        statusUI.SetActive(false);
    }

}
