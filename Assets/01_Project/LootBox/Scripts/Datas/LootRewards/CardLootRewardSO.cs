using UnityEngine;

[CreateAssetMenu(fileName = "CardLootReward", menuName = "Loot/Card Reward")]
public class CardLootRewardSO : ScriptableObject, ILootReward, ILootRewardHandler
{
    public CardDataSO CardData;
    public int Amount;

    [SerializeField] private RewardRevealedEventChannelSO revealEventChannel;

    
    public RewardRevealData GetRevealData()
    {
        int previous = PlayerInventory.Instance.GetCardCount(CardData);
        int newTotal = previous + Amount;

        int currentLevel = PlayerInventory.Instance.GetCardLevel(CardData);
        int requiredForNextLevel = CardData.GetCardsRequiredForLevel(currentLevel);

        // Handle max level or invalid requirement safely
        float previousProgress = requiredForNextLevel == 0 || requiredForNextLevel == int.MaxValue
                ? 1f
                : (float)previous / requiredForNextLevel;

        float newProgress = requiredForNextLevel == 0 || requiredForNextLevel == int.MaxValue
                ? 1f
                : (float)newTotal / requiredForNextLevel;

        // Clamp to 1f max if overfilled
        previousProgress = Mathf.Clamp01(previousProgress);
        newProgress = Mathf.Clamp01(newProgress);

        return new RewardRevealData
        {
                Name = CardData.DisplayName,
                Icon = CardData.Icon,
                Amount = Amount,
                PreviousProgress = previousProgress,
                NewProgress = newProgress,
                Handler = this // correct handler assigned
        };
    }

    public void Apply(PlayerInventory inventory)
    {
        inventory.AddCard(CardData, Amount);
    }

    // Optionally implement ILootRewardHandler methods here, or pass this to reward UI logic
    public void GrantReward(int amount)
    {
        throw new System.NotImplementedException();
    }
}