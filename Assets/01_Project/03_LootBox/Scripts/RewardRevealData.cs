using UnityEngine;

public class RewardRevealData
{
    public Sprite Icon;
    public string Name;
    public float PreviousProgress;
    public float NewProgress;
    public int Amount;

    public RewardRevealData() { }

    public RewardRevealData(Sprite icon, string name, float prevProgress, float newProgress, int amount)
    {
        Icon = icon;
        Name = name;
        PreviousProgress = prevProgress;
        NewProgress = newProgress;
        Amount = amount;
    }
}
