using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LootBoxOpener : MonoBehaviour
{
    [SerializeField] private LootBoxRewardPresenter rewardPresenter;
    [SerializeField] private LootBoxOpenedEventChannelSO onLootBoxOpened;

    public void OpenLootBox(LootBoxDataSO lootBoxData)
    {
        StartCoroutine(OpenAndRevealSequence(lootBoxData));
    }

    private IEnumerator OpenAndRevealSequence(LootBoxDataSO lootBoxData)
    {
        // Animate chest rise (can add DOTween code here)
        yield return new WaitForSeconds(1f);

        foreach (LootRewardSO rewardSO in lootBoxData.Rewards)
        {
            RewardRevealData revealData = rewardSO.GetRevealData();
            rewardPresenter.PlayRevealAnimation(revealData);

            yield return rewardPresenter.WaitForPlayerClick();
            yield return rewardPresenter.FillBarAnimation(revealData);

            rewardSO.Apply(PlayerInventory.Instance);
        }

        onLootBoxOpened.RaiseEvent(lootBoxData);
    }
}