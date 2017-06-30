using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class Shadowflame : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadowflame");
            Tooltip.SetDefault("'The secret power of the goblins'");
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
            ModRecipe recipe = new ModRecipe (mod);
            recipe.AddIngredient(ItemID.ShadowFlameHexDoll, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 20);
            recipe.AddRecipe();

            recipe = new ModRecipe (mod);
            recipe.AddIngredient(ItemID.ShadowFlameKnife, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 20);
            recipe.AddRecipe();

            recipe = new ModRecipe (mod);
            recipe.AddIngredient(ItemID.ShadowFlameBow, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }
}
        