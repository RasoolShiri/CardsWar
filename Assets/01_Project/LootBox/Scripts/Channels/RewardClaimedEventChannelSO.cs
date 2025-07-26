using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/LootBox/Reward Claimed")]
public class RewardClaimedEventChannelSO : ScriptableObject
{
    public UnityAction<LootBoxRewardSO> OnRewardClaimed;

    public void RaiseEvent(LootBoxRewardSO rewardSo)
    {
        OnRewardClaimed?.Invoke(rewardSo);
    }
}