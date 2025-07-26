using UnityEngine;

public class RewardSpawner : MonoBehaviour
{
    [SerializeField] private GameObject rewardPrefab;
    [SerializeField] private Transform rewardParent;
    [SerializeField] private RewardRevealedEventChannelSO revealedEvent;

    private void OnEnable() => revealedEvent.OnRewardRevealed += OnRevealed;
    private void OnDisable() => revealedEvent.OnRewardRevealed -= OnRevealed;

    private void OnRevealed(LootBoxRewardSO so)
    {
        var go = Instantiate(rewardPrefab, rewardParent);
        var view = go.GetComponent<RewardView>();
        view.Setup(so);
    }
}