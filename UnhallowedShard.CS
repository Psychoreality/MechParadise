using Terraria;
using Terraria.ModLoader;

namespace TerrariaQuickRecipes-Mod
        {
            public static class UnhallowedShard : ModItem
            {
                public override void SetDefaults()
                {
                item.name = "Unhallowed Shard";
                item.width = 20;
                item.height = 20;
                item.maxStack = 99;
                AddTooltip("'The holding place of ancient spirits'");
                item.value = 2000;
                item.rarity = 4;
                };
            
            public override void AddRecipes()
            {
                ModRecipe recipe = new ModRecipe (mod);
                recipe.AddIngredient(ItemID.ClockworkAssaultRifle);
                recipe.AddTile(null, "BossForge");
                recipe.SetResult(this, 10);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LaserRifle);
                recipe.AddTile(null, "BossForge");
                recipe.SetResult(this, 10);
                recipe.AddRecipe();
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BreakerBlade);
                recipe.AddTile(null, "BossForge");
                recipe.SetResult(this, 10);
                };
            };
}