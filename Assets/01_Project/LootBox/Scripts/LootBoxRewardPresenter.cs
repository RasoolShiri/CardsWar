using UnityEngine;
using System.Collections;

public class LootBoxRewardPresenter : MonoBehaviour
{
    [SerializeField] private RewardView rewardView;

    public void PlayRevealAnimation(RewardRevealData data)
    {
        rewardView.Setup(data);
        rewardView.ShowWithAnimation();
    }

    public IEnumerator WaitForPlayerClick()
    {
        yield return rewardView.WaitForClick();
    }

    public IEnumerator FillBarAnimation(RewardRevealData data)
    {
        yield return rewardView.AnimateProgress(data);
    }
}