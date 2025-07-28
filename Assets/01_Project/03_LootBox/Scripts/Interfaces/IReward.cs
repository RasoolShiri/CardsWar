public interface IReward
{
    RewardRevealData CreateRevealData(int amount, PlayerInventory inventory);
    void GrantReward(PlayerInventory inventory, int amoun);
}