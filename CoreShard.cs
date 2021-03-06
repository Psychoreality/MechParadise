using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MechParadise
{
    public class CoreShard : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lihzahrd Core Shard");
            Tooltip.SetDefault("'The magic inside heats it up'");
            }
            
        public override void SetDefaults()
        {
            item.height = 20;
            item.width = 20;
            item.maxStack = 99;
            item.value = 5000;
            item.rare = 6;
            }
        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StaffofEarth, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HeatRay, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EyeoftheGolem, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GolemFist, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Picksaw, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Stynger, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PossessedHatchet, 1);
            recipe.AddTile(null, "BossForge");
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
            }
        }
    }