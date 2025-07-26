using System.Collections.Generic;
using UnityEngine;

public class LootBoxOpener : MonoBehaviour
{
    [SerializeField] private LootBoxRewardPresenter presenter;

    public void OpenLootBox(LootBoxDataSO box)
    {
        List<LootBoxRewardSO> revealList = new List<LootBoxRewardSO>();

        foreach (var rewardDef in box.Rewards)
        {
            int amount = UnityEngine.Random.Range(rewardDef.minAmount, rewardDef.maxAmount + 1);
            ILootRewardHandler handler = rewardDef.CreateHandler();

            var revealData = new LootBoxRewardSO
            {
                Handler = handler,
                Icon = rewardDef.icon, // Add this to LootRewardDefinitionSO
                DisplayName = rewardDef.name,
                Amount = amount
            };

            revealList.Add(revealData);
        }

        presenter.StartReveal(revealList);
    }
}