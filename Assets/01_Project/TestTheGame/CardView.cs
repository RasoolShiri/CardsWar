using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardView : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI countText;

    private CardDataSO cardData;
    private int count;

    public void Setup(CardDataSO data, int amount)
    {
        cardData = data;
        count = amount;
        icon.sprite = data.Icon;
        nameText.text = data.DisplayName;
        countText.text = $"x{amount}";
    }
}