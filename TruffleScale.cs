using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class TruffleScale : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Fishron Scale";
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            AddTooltip("'This fish scale stinks of truffles'");
            item.value = 5000;
            item.rare = 7;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Flairon);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 3);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RazorbladeTyphoon);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 3);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Tsunami);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 3);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TempestStaff);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 3);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BubbleGun);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 3);
            recipe.AddRecipe();
        }
    }
}
        