using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CardsWar/CardsConfig/TypeConfig", fileName = "SO_CardLevelRequirementConfig")]

public class CardLevelRequirementConfigSO : ScriptableObject
{
    public Rarity Rarity;
    public List<int> CardsRequiredPerLevel = new List<int>(); // e.g., [5, 10, 20, 50, 100, ...]
}