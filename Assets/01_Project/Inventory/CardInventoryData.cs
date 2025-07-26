[System.Serializable]
public class CardInventoryData
{
    public int Level = 0;
    public int Count = 0;

    public void AddCards(int amount)
    {
        Count += amount;
    }

    public bool CanLevelUp(CardDataSO card)
    {
        return Level < card.GetMaxLevel() && Count >= card.GetCardsRequiredForLevel(Level);
    }

    public bool TryLevelUp(CardDataSO card)
    {
        bool leveledUp = false;

        while (CanLevelUp(card))
        {
            Count -= card.GetCardsRequiredForLevel(Level);
            Level++;
            leveledUp = true;
        }

        return leveledUp;
    }
}