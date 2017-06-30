using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class FoolsGold : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fool's Gold");
            Tooltip.SetDefault("'A warped plate of metal stolen by pirates'");
            }
            
        public override void SetDefaults()
        {
            item.name = "Fool's Gold";
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = 2000;
            item.rare = 4;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PirateStaff, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 20);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LuckyCoin, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 20);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldRing, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 20);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DiscountCard, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }
}
    