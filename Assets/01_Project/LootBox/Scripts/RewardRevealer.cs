using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardRevealer : MonoBehaviour
{
    [SerializeField] private RewardRevealedEventChannelSO rewardRevealedEvent;
    [SerializeField] private RewardClaimedEventChannelSO rewardClaimedEvent;

    public void RevealRewards(List<LootBoxRewardSO> rewards)
    {
        StartCoroutine(RevealRoutine(rewards));
    }

    private IEnumerator RevealRoutine(List<LootBoxRewardSO> rewards)
    {
        foreach (var reward in rewards)
        {
            rewardRevealedEvent.RaiseEvent(reward);
            yield return new WaitUntil(() => reward.IsClaimed);
            rewardClaimedEvent.RaiseEvent(reward);
        }
    }
}