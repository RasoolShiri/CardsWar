using UnityEngine;
using System.Collections;

public class LootBoxOpener : MonoBehaviour
{
    [SerializeField]
    private LootBoxRewardPresenter rewardPresenter;

    [SerializeField]
    private LootBoxOpenedEventChannelSO onLootBoxOpened;

    public void OpenLootBox(LootBoxDataSO lootBoxData)
    {
        StartCoroutine(OpenAndRevealSequence(lootBoxData));
    }

    private IEnumerator OpenAndRevealSequence(LootBoxDataSO lootBoxData)
    {
        // Animate chest rise (can add DOTween code here)
        yield return new WaitForSeconds(1f);

        foreach (RewardSO rewardSO in lootBoxData.Rewards)
        {
            int rewardCount = Random.Range(rewardSO.MinAmount, rewardSO.MaxAmount);
            RewardRevealData revealData = rewardSO.CreateRevealData(rewardCount, PlayerInventory.Instance);
            rewardPresenter.PlayRevealAnimation(revealData);

            yield return rewardPresenter.WaitForPlayerClick();
            yield return rewardPresenter.FillBarAnimation(revealData);

            rewardSO.GrantReward(PlayerInventory.Instance, rewardCount);
        }

        onLootBoxOpened.RaiseEvent(lootBoxData);
    }
}