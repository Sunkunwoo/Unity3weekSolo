using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiManager : MonoBehaviour
{
    public GameObject player;
    public TMP_Text lvTxt;
    public TMP_Text hpTxt;
    public TMP_Text atkTxt;
    public TMP_Text defTxt;
    public TMP_Text expTxt;
    public TMP_Text jobTxt;
    public TMP_Text goldTxt;
    private void Start()
    {
    }
    void Update()
    {
        if (player != null)
        {
            lvTxt.text = player.GetComponent<PlayerInfo>().CurrentStats.lv.ToString();
            hpTxt.text = player.GetComponent<PlayerInfo>().CurrentStats.maxHp.ToString();
            atkTxt.text = player.GetComponent<PlayerInfo>().CurrentStats.atk.ToString();
            defTxt.text = player.GetComponent<PlayerInfo>().CurrentStats.def.ToString();
            expTxt.text = player.GetComponent<PlayerInfo>().CurrentStats.exp.ToString() + "/" + player.GetComponent<PlayerInfo>().CurrentStats.maxExp.ToString();
            jobTxt.text = player.GetComponent<PlayerInfo>().CurrentStats.job.ToString();
            goldTxt.text = player.GetComponent<PlayerInfo>().CurrentStats.gold.ToString();
        }
        else
        {
            Debug.Log("Player is not");
        }
    }

}
