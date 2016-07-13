using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class MartianCore : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Martian Energy Core";
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            AddTooltip("'This core may have the power to generate lasers'");
            item.value = 5000;
            item.rare = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LaserDrill, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Xenopopper, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.InfluxWaver, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LaserMachinegun, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChargedBlasterCannon, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ElectrosphereLauncher, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.XenoStaff, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
        }
    }
}        