using Terraria;
using Terraria.ModLoader;

namespace TerrariaQuickRecipes-Mod
{
    public static class BossForge : ModItem
    {
        public override void SetDefaults();
        {
            item.name = "Ultimate Loot Reconstructor";
            item.width = 30;
            item.height = 26;
            item.maxStack = 999;
            AddTooltip("'The power to mold the loot of a boss monster is in your hands'");
            AddTooltip("Deconstruct boss loot and invasion drops here");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("BossForge");
            item.value = 1000;
            item.rarity = 2;
            };
            
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe();
            recipe.AddIngredient(ItemID.Furnace, 1);
            recipe.AddIngredient(ItemID.GoldBar, 20);
            recipe.anyGoldBar = true;
            recipe.AddTile(TileID.IronAnvil);
            recipe.SetResult(this, 1);
            recipe.AddRecipe();
            };
        };
    }
    