using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class Shadowflame : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Shadowflame";
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            AddTooltip("'The secret to the power of the goblins'");
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
        