using UnityEngine;

public class RewardRevealData
{
    public Sprite Icon;
    public string Name;
    public float PreviousProgress;
    public float NewProgress;
    public ILootRewardHandler Handler;
    public int Amount;
    
    // Parameterless constructor for object initializer
    public RewardRevealData() { }
    
    public RewardRevealData(Sprite icon, string name, float prevProgress, float newProgress, ILootRewardHandler handler, int amount)
    {
        Icon = icon;
        Name = name;
        PreviousProgress = prevProgress;
        NewProgress = newProgress;
        Handler = handler;
        Amount = amount;
    }
}