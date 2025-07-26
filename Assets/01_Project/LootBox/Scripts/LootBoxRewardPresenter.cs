using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootBoxRewardPresenter : MonoBehaviour
{
    [SerializeField] private Transform rewardParent;
    [SerializeField] private GameObject rewardPrefab;

    private Queue<LootBoxRewardSO> queue = new();

    public void StartReveal(List<LootBoxRewardSO> rewards)
    {
        queue.Clear();
        foreach (var r in rewards)
            queue.Enqueue(r);

        StartCoroutine(RevealSequence());
    }

    private IEnumerator RevealSequence()
    {
        while (queue.Count > 0)
        {
            var reward = queue.Dequeue();

            GameObject go = Instantiate(rewardPrefab, rewardParent);
            var view = go.GetComponent<RewardView>();
            view.Setup(reward);

            yield return view.PlayRevealAnimation(reward.Amount);

            // 🖱️ Wait for tap/click before next
            yield return new WaitUntil(() => Input.GetMouseButtonDown(0));

            reward.Handler.GrantReward(reward.Amount);
        }

        // Done!
        Debug.Log("All rewards revealed.");
    }
}