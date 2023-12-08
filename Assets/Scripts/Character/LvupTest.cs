using UnityEngine;

public class LvupTest : MonoBehaviour
{
    LvupSystem lvupSystem;
    int getExp = 10;

    private void Start()
    {
        GameObject player = GameObject.Find("Player");
        lvupSystem = player.GetComponent<LvupSystem>();
    }
    public void GetExpBtn()
    {
            lvupSystem.LvUpStatus(getExp);
    }
}
