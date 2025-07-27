using UnityEngine;

[CreateAssetMenu(menuName = "LootBox/Reward")]
public abstract class LootRewardSO : ScriptableObject,ILootReward
{
    public ILootRewardHandler Handler;
    public Sprite Icon;
    public string DisplayName;
    public int minAmount;
    public int maxAmount;
    public bool IsClaimed;
    
    public abstract ILootRewardHandler CreateHandler();

    public RewardRevealData GetRevealData()
    {
        throw new System.NotImplementedException();
    }

    public void Apply(PlayerInventory inventory)
    {
        throw new System.NotImplementedException();
    }
}