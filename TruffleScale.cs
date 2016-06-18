using Terraria;
using Terraria.ModLoader;

namespace TerrariaQuickRecipes-Mod;
{
     public static class TruffleScale : ModItem
        {
            public override void SetDefaults()
            {
                item.name = "Fishron Scale";
                item.width = 20;
                item.height = 20;
                item.maxStack = 99;
                AddTooltip("'This fish scale stinks of truffles'");
                item.value = 5000;
                item.rarity = 7;
                };
                
            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Flairon);
                recipe.AddTile(ItemID.MythrilAnvil);
                recipe.SetResult(this, 3);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.RazorbladeTyphoon);
                recipe.AddTile(ItemID.MythrilAnvil);
                recipe.SetResult(this, 3);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Tsunami);
                recipe.AddTile(ItemID.MythrilAnvil);
                recipe.SetResult(this, 3);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TempestStaff);
                recipe.AddTile(ItemID.MythrilAnvil);
                recipe.SetResult(this, 3);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BubbleGun);
                recipe.AddTile(ItemID.MythrilAnvil);
                recipe.SetResult(this, 3);
                recipe.AddRecipe();
                };
            };
        }
        