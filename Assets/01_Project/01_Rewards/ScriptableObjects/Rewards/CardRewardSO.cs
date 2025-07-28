using UnityEngine;

[CreateAssetMenu(menuName = "CardsWar/Rewards/Card", fileName = "SO_Reward_Card")]

public class CardRewardSO : RewardSO
{
    [SerializeField] private CardDataSO cardData;
    [SerializeField] private RewardRevealedEventChannelSO revealEvent;

    public override RewardRevealData CreateRevealData(int amount, PlayerInventory inventory)
    {
        int previousCount = inventory.GetCardCount(cardData);
        int newTotal = previousCount + amount;

        int currentLevel = inventory.GetCardLevel(cardData);
        int requiredForNext = cardData.GetCardsRequiredForLevel(currentLevel);

        float prevProgress = requiredForNext <= 0 ? 1f : (float)previousCount / requiredForNext;
        float newProgress = requiredForNext <= 0 ? 1f : (float)newTotal / requiredForNext;

        return new RewardRevealData
        {
                Icon = cardData.Icon,
                Name = cardData.CardName,
                PreviousProgress = Mathf.Clamp01(prevProgress),
                NewProgress = Mathf.Clamp01(newProgress),
                Amount = amount
        };
    }

    public override void GrantReward(PlayerInventory inventory, int amount)
    {
        inventory.AddCard(cardData, amount);

        RewardRevealData reveal = CreateRevealData(amount, inventory);
        revealEvent?.RaiseEvent(reveal);
    }

}