using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class LunarHeart : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Lunar Core";
            item.height = 20;
            item.width = 20;
            item.maxStack = 99;
            item.rare = 9;
            AddTooltip("'The bringer of apocalypse's ultimate prize'");
            item.value = 30000;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SDMG);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LastPrism);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StarWrath);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Terrarian);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Meowmere);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarFlareBook);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MoonlordTurretStaff);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RainbowCrystalStaff);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FireworksLauncher);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}