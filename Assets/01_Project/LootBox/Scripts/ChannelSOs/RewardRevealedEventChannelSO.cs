using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/LootBox/Reward Revealed")]
public class RewardRevealedEventChannelSO : ScriptableObject
{
    public UnityAction<RewardRevealData> OnRewardRevealed;

    public void RaiseEvent(RewardRevealData rewardSo)
    {
        OnRewardRevealed?.Invoke(rewardSo);
    }
}