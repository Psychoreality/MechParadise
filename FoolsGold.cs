using Terraria;
using Terraria.ModLoader;

namespace TerrariaQuickRecipes-Mod
{
     public static class FoolsGold : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Fool's Gold";
            item.width = 20
            item.height = 20
            item.maxStack = 99;
            AddTooltip("'A warped plate of metal stolen by pirates'");
            item.value = 2000;
            item.rarity = 4;
            };
            
            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(Terraria.ID.ItemID.PirateStaff, 1);
                recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
                recipe = new ModRecipe (mod);
                recipe.AddIngredient(Terraria.ID.ItemID.LuckyCoin, 1);
                recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
                recipe = new ModRecipe (mod);
                recipe.AddIngredient(Terraria.ID.ItemID.GoldRing, 1);
                recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
                recipe = new ModRecipe (mod);
                recipe.AddIngredient(Terraria.ID.ItemID.DiscountCard, 1);
                recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
                };
                
        };
    }
    