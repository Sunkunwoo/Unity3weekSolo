using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum StatsChangeType
{
    Add,
    Multiple,
    Override,
}

public enum JobType
{
    Knight = 1,
    Magician = 2,
    Rogue = 3,
}
[Serializable]
public class CharactorStats
{
    public StatsChangeType statsChangeType;
    public JobType job;
    public int maxHp;
    public int atk;
    public int def;
    public int lv;
    public float exp;
    public float maxExp;
    public int gold;
}
