using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private CharactorStats baseStats;
    public CharactorStats CurrentStats { get; private set;}
    public List<CharactorStats> statsModifiers = new List<CharactorStats>();

    private void Awake()
    {
        CurrentStats = new CharactorStats();
        LoadInitialStats(CurrentStats.job);
        DontDestroyOnLoad(this);
    }

    private void Start()
    {
    }
    //private void UpdateCharacterStats()
    //{
    //    CurrentStats = new CharactorStats();
    //}

    private string csvFilePath = "Assets/CSV/Data.csv";
    public CharactorStats LoadInitialStats(JobType jobType)
    {
        string[] lines = File.ReadAllLines(csvFilePath);

        foreach (string line in lines)
        {
            string[] values = line.Split(',');

            if (Enum.TryParse(values[0], out JobType job))
            {
                if (job == jobType)
                {
                    if (values.Length >= 8)
                    {
                        CharactorStats stats = new CharactorStats
                        {
                            job = job,
                            maxHp = int.Parse(values[1]),
                            atk = int.Parse(values[2]),
                            def = int.Parse(values[3]),
                            lv = int.Parse(values[4]),
                            exp = float.Parse(values[5]),
                            maxExp = float.Parse(values[6]),
                            gold = int.Parse(values[7])
                        };
                        return stats;
                    }
                    else
                    {
                        Debug.LogError("CSV 파일의 열 개수가 부족합니다.");
                    }
                }
            }
        }
        Debug.LogError("데이터가 없습니다.");
        return new CharactorStats();
    }
}
