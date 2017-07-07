using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class UnhallowedShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Unhallowed Shard");
            Tooltip.SetDefault("'The holding place of ancient spirits'");
            }
            
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 2000;
            item.rare = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ClockworkAssaultRifle);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LaserRifle);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 10);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BreakerBlade);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 10);
        }
    }
}