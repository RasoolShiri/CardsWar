using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/LootBox/Reward Revealed")]
public class RewardRevealedEventChannelSO : ScriptableObject
{
    public UnityAction<LootBoxRewardSO> OnRewardRevealed;

    public void RaiseEvent(LootBoxRewardSO rewardSo)
    {
        OnRewardRevealed?.Invoke(rewardSo);
    }
}