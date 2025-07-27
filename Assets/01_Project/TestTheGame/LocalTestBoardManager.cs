using System.Collections.Generic;
using UnityEngine;

public class LocalTestBoardManager : MonoBehaviour
{
    [SerializeField] private Transform player1Area;
    [SerializeField] private Transform player2Area;
    [SerializeField] private GameObject cardPrefab;

    [SerializeField] private List<CardDataSO> testDeckPlayer1;
    [SerializeField] private List<CardDataSO> testDeckPlayer2;

    private void Start()
    {
        foreach (var card in testDeckPlayer1)
        {
            var go = Instantiate(cardPrefab, player1Area);
           // go.GetComponent<CardView>().Setup(card, 1);
        }

        foreach (var card in testDeckPlayer2)
        {
            var go = Instantiate(cardPrefab, player2Area);
            //go.GetComponent<CardView>().Setup(card, 1);
        }
    }
}