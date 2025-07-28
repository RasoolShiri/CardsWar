using UnityEngine;

[CreateAssetMenu(menuName = "CardsWar/Rewards/Coin", fileName = "SO_Reward_Coin")]
public class CoinRewardSO : RewardSO
{
    public override RewardRevealData CreateRevealData(int amount, PlayerInventory inventory)
    {
        throw new System.NotImplementedException();
    }

    public override void GrantReward(PlayerInventory inventory, int amount)
    {
        throw new System.NotImplementedException();
    }
}