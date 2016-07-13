using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class TornWrap : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Torn Gift Wrapping";
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            AddTooltip("'Opening these presents may void the warranty'");
            item.value = 4000;
            item.rare = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EldMelter, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChainGun, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Razorpine, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChristmasTreeSword, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlizzardStaff, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NorthPole, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SnowmanCannon, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}