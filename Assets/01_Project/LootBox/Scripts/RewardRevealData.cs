using UnityEngine;

public class RewardRevealData
{
    public ILootRewardHandler Handler { get; }
    public int Amount { get; }
    public Sprite Icon { get; }
    public string LocalizedName { get; }

    public RewardRevealData(LootBoxRewardSO so, int amount, ILootRewardHandler handler)
    {
        Handler = handler;
        Amount = amount;
        Icon = so.Icon;
        LocalizedName = so.localizedKey;
    }
}