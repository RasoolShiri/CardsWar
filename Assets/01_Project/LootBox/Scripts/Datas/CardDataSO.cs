using UnityEngine;

[CreateAssetMenu(menuName = "Cards/Card Data")]
public class CardDataSO : ScriptableObject
{
    public CardType Type;
    public string DisplayName;
    public Sprite Icon;
    public int BaseHealth;
    public int BaseAttack;
    public Rarity Rarity;
    
    public int[] RequiredCardsForLevels;

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
