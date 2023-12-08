using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEQ : MonoBehaviour
{
    PlayerInfo playerInfo;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        playerInfo = player.GetComponent<PlayerInfo>();
    }
    
    void isEqCheck()
    {

    }
}
