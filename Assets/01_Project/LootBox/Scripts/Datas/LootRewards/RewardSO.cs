using UnityEngine;

[CreateAssetMenu(menuName = "LootBox/Reward")]
public abstract class RewardSO : ScriptableObject, IReward
{
    [Header("Reward Info")]
    public Sprite Icon;
    public string RewardName;
    public int MinAmount;
    public int MaxAmount;
    
    public abstract RewardRevealData CreateRevealData(int amount, PlayerInventory inventory);
    public abstract void GrantReward(PlayerInventory inventory, int amoun);
}