using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/LootBox/Open")]
public class LootBoxOpenedEventChannelSO : ScriptableObject
{
    public UnityAction<LootBoxDataSO> OnLootBoxOpened;

    public void RaiseEvent(LootBoxDataSO lootBoxData)
    {
        OnLootBoxOpened?.Invoke(lootBoxData);
    }
}