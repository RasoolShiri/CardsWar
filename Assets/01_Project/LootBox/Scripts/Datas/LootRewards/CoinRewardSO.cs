using UnityEngine;

[CreateAssetMenu(menuName = "Loot/CoinLootReward", fileName = "CoinLootReward")]
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