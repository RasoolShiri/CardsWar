using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class RewardView : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI title;
    [SerializeField] private Slider progressBar;

    private bool clicked;

    public void Setup(RewardRevealData data)
    {
        icon.sprite = data.Icon;
        title.text = data.Name;
        progressBar.value = data.PreviousProgress;
    }

    public void ShowWithAnimation()
    {
        gameObject.SetActive(true);
        clicked = false;
    }

    public IEnumerator WaitForClick()
    {
        while (!clicked)
        {
            if (Input.GetMouseButtonDown(0)) clicked = true;
            yield return null;
        }
    }

    public IEnumerator AnimateProgress(RewardRevealData data)
    {
        float duration = 0.5f;
        float elapsed = 0f;
        float start = data.PreviousProgress;
        float end = data.NewProgress;

        while (elapsed < duration)
        {
            progressBar.value = Mathf.Lerp(start, end, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }

        progressBar.value = end;
    }
}