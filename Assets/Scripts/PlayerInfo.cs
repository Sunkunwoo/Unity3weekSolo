using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    [SerializeField] private CharactorStats baseStats;
    public CharactorStats CurrentStates {get; private set;}
    public List<CharactorStats> statsModifiers = new List<CharactorStats>();

    private void Awake()
    {
        UpdateCharacterStats();
    }

    private void UpdateCharacterStats()
    {
        CurrentStates = new CharactorStats();
        CurrentStates.maxHp = baseStats.maxHp;

    }
}
