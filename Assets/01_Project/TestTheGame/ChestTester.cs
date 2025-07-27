using UnityEngine;
using System.Collections.Generic;

public class ChestTester : MonoBehaviour
{
    [SerializeField] private List<RewardSO> testRewards;
    [SerializeField] private PlayerInventory testInventory;

    [SerializeField] private ChestAnimationController chestAnimation;
   // [SerializeField] private RewardRevealUIController rewardUI;

    private List<RewardRevealData> revealedRewards;
    private int currentRewardIndex;

    private void Start()
    {
        // Start with closed chest
        chestAnimation.PlayOpenAnimation(OnChestOpened);
    }

    private void OnChestOpened()
    {
        revealedRewards = new List<RewardRevealData>();
        foreach (var reward in testRewards)
        {
            int amount = Random.Range(reward.MinAmount, reward.MaxAmount + 1);
        //    reward.GrantReward(testInventory);
            revealedRewards.Add(reward.CreateRevealData(amount, testInventory));
        }

        currentRewardIndex = 0;
        ShowNextReward();
    }

    public void ShowNextReward()
    {
        if (currentRewardIndex >= revealedRewards.Count)
        {
            Debug.Log("All rewards shown!");
            return;
        }

      //  rewardUI.ShowReward(revealedRewards[currentRewardIndex]);
        currentRewardIndex++;
    }

    // Hook this to button click in UI to show next
    public void OnNextClicked()
    {
        ShowNextReward();
    }
}