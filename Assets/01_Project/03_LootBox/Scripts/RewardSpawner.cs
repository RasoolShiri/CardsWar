using System.Collections;
using UnityEngine;

public class RewardSpawner : MonoBehaviour
{
    [SerializeField] private GameObject rewardPrefab;
    [SerializeField] private Transform rewardParent;
    [SerializeField] private RewardRevealedEventChannelSO revealedEvent;

    private void OnEnable() => revealedEvent.OnRewardRevealed += OnRevealed;
    private void OnDisable() => revealedEvent.OnRewardRevealed -= OnRevealed;

    private void OnRevealed(RewardRevealData data)
    {
        var go = Instantiate(rewardPrefab, rewardParent);
        var view = go.GetComponent<RewardView>();
        view.Setup(data);
        view.ShowWithAnimation();

        StartCoroutine(HandleRewardReveal(view, data));
    }
    
    private IEnumerator HandleRewardReveal(RewardView view, RewardRevealData data)
    {
        yield return view.AnimateProgress(data);
        yield return view.WaitForClick();
        // optionally destroy or hide the view
    }
}