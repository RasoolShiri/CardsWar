using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loot/Loot Box")]
public class LootBoxDataSO : ScriptableObject
{
    public List<LootRewardDefinitionSO> Rewards;
}