using UnityEngine;

public class LvupSystem : MonoBehaviour
{
    PlayerInfo playerInfo;
    // Start is called before the first frame update
    void Start()
    {
        playerInfo = gameObject.GetComponent<PlayerInfo>();
    }

    public void LvUpStatus(int getExp)
    {
        playerInfo.CurrentStats.exp += getExp;
        if (playerInfo.CurrentStats.exp >= playerInfo.CurrentStats.maxExp)
        {
            playerInfo.CurrentStats.exp -= playerInfo.CurrentStats.maxExp;
            playerInfo.CurrentStats.maxExp = playerInfo.CurrentStats.maxExp * 2;
            playerInfo.CurrentStats.lv += 1;
            playerInfo.CurrentStats.atk += playerInfo.CurrentStats.upAtk;
            playerInfo.CurrentStats.def += playerInfo.CurrentStats.upDef;
            playerInfo.CurrentStats.maxHp += playerInfo.CurrentStats.upMaxHp;
        }
    }
}
