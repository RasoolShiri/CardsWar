using UnityEngine;

[CreateAssetMenu(menuName = "LootBox/Reward")]
public class LootBoxRewardSO : ScriptableObject
{
    public ILootRewardHandler Handler;
    public Sprite Icon;
    public string localizedKey;
    public string DisplayName;
    public int Amount;
    public bool IsClaimed;
}