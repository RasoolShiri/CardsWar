using UnityEngine;

[CreateAssetMenu(menuName = "RewardHandlers/Coin")]
public class CoinRewardHandlerSO : ScriptableObject, ILootRewardHandler
{
    public void GrantReward(int amount)
    {
      //  PlayerWallet.Instance.AddCoins(amount);
    }
}