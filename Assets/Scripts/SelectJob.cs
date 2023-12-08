using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectJob : MonoBehaviour
{
    public GameObject player;
    public void SelectKnight()
    {
        GameManager.Instance.charactorStats.job = JobType.Knight;
        SceneManager.LoadScene("02");
    }

    public void SelectMagician()
    {
        GameManager.Instance.charactorStats.job = JobType.Magician;
        SceneManager.LoadScene("02");
    }

    public void SelectRogue()
    {
        GameManager.Instance.charactorStats.job = JobType.Rogue;
        SceneManager.LoadScene("02");
    }
}
