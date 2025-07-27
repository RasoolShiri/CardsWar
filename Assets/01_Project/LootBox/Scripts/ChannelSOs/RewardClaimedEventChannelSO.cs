using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/LootBox/Reward Claimed")]
public class RewardClaimedEventChannelSO : ScriptableObject
{
    public UnityAction<RewardSO> OnRewardClaimed;

    public void RaiseEvent(RewardSO rewardSo)
    {
        OnRewardClaimed?.Invoke(rewardSo);
    }
}