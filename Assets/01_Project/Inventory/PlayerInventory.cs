using UnityEngine;
using System.Collections.Generic;

using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public static PlayerInventory Instance;

    private Dictionary<CardDataSO, CardInventoryData> cards = new();

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void AddCard(CardDataSO card, int amount)
    {
        if (!cards.TryGetValue(card, out var data))
        {
            data = new CardInventoryData();
            cards[card] = data;
        }

        data.AddCards(amount);
        data.TryLevelUp(card);
    }

    public int GetCardCount(CardDataSO card)
    {
        return cards.TryGetValue(card, out var data) ? data.Count : 0;
    }

    public int GetCardLevel(CardDataSO card)
    {
        return cards.TryGetValue(card, out var data) ? data.Level : 0;
    }

    public CardInventoryData GetData(CardDataSO card)
    {
        if (!cards.ContainsKey(card))
            cards[card] = new CardInventoryData();

        return cards[card];
    }

    public void AddCoins(int amount)
    {
        throw new System.NotImplementedException();
    }
}
