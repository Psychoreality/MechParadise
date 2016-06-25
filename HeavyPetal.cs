using Terraria;
using Terraria.ModLoader;

namespace TerrariaQuickRecipes-Mod;
{
    public static class HeavyPetal : ModItem
    {
        public override void SetDefaults();
        {
            item.name = "Heavy Petal";
            item.height = 20;
            item.width = 20;
            item.maxStack = 99;
            AddTooltip("'Smells like teen cologne'");
            item.value = 2000;
            item.rarity = 6;
            };
        public override void AddRecipes();
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Seedler, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GrenadeLauncher, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PygmyStaff, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NettleBurst, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeafBlower, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaspGun, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlowerPow, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();