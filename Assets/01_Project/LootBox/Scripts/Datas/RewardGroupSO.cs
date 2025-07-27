using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Test/TestRewardGroup")]
public class RewardGroupSO : ScriptableObject
{
    public List<RewardSO> rewards;
}