using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "CardsWar/LootBox/Chest/RewardRevealed", fileName = "SO_LootBox_RewardRevealed")]
public class RewardRevealedEventChannelSO : ScriptableObject
{
    public UnityAction<RewardRevealData> OnRewardRevealed;

    public void RaiseEvent(RewardRevealData rewardSo)
    {
        OnRewardRevealed?.Invoke(rewardSo);
    }
}