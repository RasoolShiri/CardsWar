public interface ILootReward
{
    RewardRevealData GetRevealData();
    void Apply(PlayerInventory inventory);
}