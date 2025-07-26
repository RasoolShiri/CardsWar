using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RewardView : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI label;
    [SerializeField] private Slider fillBar;
    [SerializeField] private TextMeshProUGUI amountText;

    public void Setup(LootBoxRewardSO so)
    {
        icon.sprite = so.Icon;
        label.text = so.DisplayName;
        amountText.text = $"x{so.Amount}";
        fillBar.value = 0;
//        StartCoroutine(PlayReveal());
    }

    public IEnumerator PlayRevealAnimation(int targetAmount)
    {
        float duration = 0.5f;
        float timer = 0;
        while (timer < duration)
        {
            timer += Time.deltaTime;
            float progress = Mathf.Clamp01(timer / duration);
            fillBar.value = progress;
            yield return null;
        }

        fillBar.value = 1;
        
        
        
        // private IEnumerator PlayReveal()
        // {
        //     // Use DOTween or FEEL
        //     yield return transform.DOScale(Vector3.one, 0.5f).SetEase(Ease.OutBack);
        //
        //     yield return new WaitUntil(() => Input.GetMouseButtonDown(0));
        //
        //     data.Handler.GrantReward(data.Amount);
        //     data.IsClaimed = true;
        // }
    }
}