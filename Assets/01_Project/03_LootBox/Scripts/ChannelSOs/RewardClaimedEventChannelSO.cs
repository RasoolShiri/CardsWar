using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "CardsWar/LootBox/Chest/RewardClaimed", fileName = "SO_LootBox_ChestRewardClaimed")]

public class RewardClaimedEventChannelSO : ScriptableObject
{
    public UnityAction<RewardSO> OnRewardClaimed;

    public void RaiseEvent(RewardSO rewardSo)
    {
        OnRewardClaimed?.Invoke(rewardSo);
    }
}