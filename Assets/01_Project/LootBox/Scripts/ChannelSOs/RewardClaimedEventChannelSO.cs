using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/LootBox/Reward Claimed")]
public class RewardClaimedEventChannelSO : ScriptableObject
{
    public UnityAction<LootRewardSO> OnRewardClaimed;

    public void RaiseEvent(LootRewardSO rewardSo)
    {
        OnRewardClaimed?.Invoke(rewardSo);
    }
}