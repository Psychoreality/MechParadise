using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class HeavyPetal : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Heavy Petal");
            Tooltip.SetDefault("'Whatever this belonged to had a lot of nothing to say'");
            }
            
        public override void SetDefaults()
        {
            item.height = 20;
            item.width = 20;
            item.maxStack = 99;
            item.value = 2000;
            item.rare = 6;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Seedler, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrenadeLauncher, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PygmyStaff, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NettleBurst, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeafBlower, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaspGun, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlowerPow, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.VenusMagnum, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}