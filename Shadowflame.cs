using Terraria;
using Terraria.ModLoader;

namespace TerrariaQuickRecipes-Mod
{
    public static class Shadowflame : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Shadowflame";
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            AddTooltip("'The secret to the power of the goblins'");
            item.value = 2000;
            item.rarity = 4;
            };
            
            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe (mod);
                recipe.AddIngredient(Terraria.ID.ItemID.ShadowflameHexDoll, 1);
                recipe.AddTile(Terraria.ID.TileID.CrystalBall);
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
                recipe = new ModRecipe (mod);
                recipe.AddIngredient(Terraria.ID.ItemID.ShadowflameKnife, 1);
                recipe.AddTile(Terraria.ID.TileID.CrystalBall);
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
                recipe = new ModRecipe (mod);
                recipe.AddIngredient(Terraria.ID.ItemID.ShadowflameBow, 1);
                recipe.AddTile(Terraria.ID.TileID.CrystalBall);
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
                };
            };
        }
        