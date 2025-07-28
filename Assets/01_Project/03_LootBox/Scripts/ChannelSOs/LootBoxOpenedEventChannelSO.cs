using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "CardsWar/LootBox/Chest/Open", fileName = "SO_LootBox_ChestOpen")]

public class LootBoxOpenedEventChannelSO : ScriptableObject
{
    public UnityAction<LootBoxDataSO> OnLootBoxOpened;

    public void RaiseEvent(LootBoxDataSO lootBoxData)
    {
        OnLootBoxOpened?.Invoke(lootBoxData);
    }
}