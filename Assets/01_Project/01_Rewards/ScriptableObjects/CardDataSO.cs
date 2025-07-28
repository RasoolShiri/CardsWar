using UnityEngine;

[CreateAssetMenu(menuName = "CardsWar/CardsConfig/Cards", fileName = "SO_CardData")]
public class CardDataSO : ScriptableObject
{
//    public CardType Type;
    public string CardName;
    public Sprite Icon;
    // public int BaseHealth;
    // public int BaseAttack;
    public Rarity Rarity;
    

    [Header("Config")]
    public CardLevelRequirementDatabase LevelRequirementDatabase;

    public int GetCardsRequiredForLevel(int level)
    {
        return LevelRequirementDatabase.GetCardsRequiredForLevel(Rarity, level);
    }
    public int GetMaxLevel()
    {
        return LevelRequirementDatabase.GetMaxLevel(Rarity);
    }
}
