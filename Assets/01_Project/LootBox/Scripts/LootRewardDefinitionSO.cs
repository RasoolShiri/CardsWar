using UnityEngine;

public abstract class LootRewardDefinitionSO : ScriptableObject
{
    public int minAmount;
    public int maxAmount;
    public Sprite icon;
    
    public abstract ILootRewardHandler CreateHandler();
}