using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectJob : MonoBehaviour
{
    public GameObject player;
    public void SelectKnight()
    {
        player.GetComponent<PlayerInfo>().CurrentStats.job = JobType.Knight;
        player.GetComponent<PlayerInfo>().LoadInitialStats(JobType.Knight);
        SceneManager.LoadScene("02");
        Instantiate(player);
    }

    public void SelectMagician()
    {
        player.GetComponent<PlayerInfo>().CurrentStats.job = JobType.Magician;
        player.GetComponent<PlayerInfo>().LoadInitialStats(JobType.Magician);
        SceneManager.LoadScene("02");
        Instantiate(player);
    }

    public void SelectRogue()
    {
        player.GetComponent<PlayerInfo>().CurrentStats.job = JobType.Rogue;
        player.GetComponent<PlayerInfo>().LoadInitialStats(JobType.Rogue);
        SceneManager.LoadScene("02");
        Instantiate(player);
    }
}
