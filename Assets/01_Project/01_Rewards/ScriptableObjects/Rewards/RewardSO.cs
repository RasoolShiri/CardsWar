using UnityEngine;

[CreateAssetMenu(menuName = "CardsWar/Rewards/BaseReward", fileName = "SO_Reward_BaseClass")]
public abstract class RewardSO : ScriptableObject, IReward
{
    [Header("Reward Info")]
    public int MinAmount;
    public int MaxAmount;
    
    public abstract RewardRevealData CreateRevealData(int amount, PlayerInventory inventory);
    public abstract void GrantReward(PlayerInventory inventory, int amoun);
}