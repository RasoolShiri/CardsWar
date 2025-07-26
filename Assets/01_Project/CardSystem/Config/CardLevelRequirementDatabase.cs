using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CardLevelRequirementDatabase : ScriptableObject
{
    public List<CardLevelRequirementConfigSO> RarityConfigs;

    private Dictionary<Rarity, CardLevelRequirementConfigSO> _lookup;

    public void Init()
    {
        _lookup = RarityConfigs.ToDictionary(config => config.Rarity, config => config);
    }

    public int GetCardsRequiredForLevel(Rarity rarity, int level)
    {
        if (_lookup == null)
            Init();

        if (_lookup.TryGetValue(rarity, out var config))
        {
            if (level < config.CardsRequiredPerLevel.Count)
                return config.CardsRequiredPerLevel[level];
        }

        return int.MaxValue; // Or throw or return 0
    }


    public int GetMaxLevel(Rarity rarity)
    {
        if (_lookup.TryGetValue(rarity, out var config))
        {
            return config.CardsRequiredPerLevel.Count - 1;
        }
        return int.MaxValue; // Or throw or return 0
    }
}