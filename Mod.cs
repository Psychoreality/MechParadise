using Terraria.ID;
using Terraria.ModLoader;

public static class TrapRecipes
{

    ModRecipe recipe;

    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 30);
    recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.ThrowingKnife, 50);
    recipe.SetResult(Terraria.ID.ItemID.DartTrap, 1);
    recipe.AddRecipe();

    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.CopperBar, 5);
    recipe.AddIngredient(Terraria.ID.ItemID.Gel, 50);
    recipe.SetResult(Terraria.ID.ItemID.Wire, 10);
    recipe.AddRecipe();

    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.TinBar, 5);
    recipe.AddIngredient(Terraria.ID.ItemID.Gel, 50);
    recipe.SetResult(Terraria.ID.ItemID.Wire, 10);
    recipe.AddRecipe();

    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.DartTrap, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 20);
    recipe.AddIngredient(Terraria.ID.ItemID.VialOfVenom, 1);
    recipe.SetResult(Terraria.ID.ItemID.SuperDartTrap, 1);
    recipe.AddRecipe();

    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.DartTrap, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 20);
    recipe.AddIngredient(Terraria.ID.ItemID.Gel, 200);
    recipe.SetResult(Terraria.ID.ItemID.FlameTrap, 1);
    recipe.AddRecipe();

    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 30);
    recipe.AddIngredient(Terraria.ID.ItemID.SpikyBall, 200);
    recipe.SetResult(Terraria.ID.ItemID.SpikyBallTrap, 1);
    recipe.AddRecipe();

    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 30);
    recipe.AddIngredient(Terraria.ID.ItemID.Spike, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.IronBar, 5);
    recipe.SetResult(Terraria.ID.ItemID.SpearTrap, 1);
    recipe.AddRecipe();

    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LizahrdBrick, 30);
    recipe.AddIngredient(Terraria.ID.ItemID.Spike, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LeadBar, 5);
    recipe.SetResult(Terraria.ID.ItemID.SpearTrap, 1);
    recipe.AddRecipe();
    
}

public static class EquipRecipes
{
    ModRecipe recipe;
    
    recipe = new ModRecipe (this);
    recipe.AddIngredient(Terraria.ID.ItemID.BandOfRegeneration, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.ManaCrystal, 1);
    recipe.SetResult(Terraria.ID.ItemID.BandOfStarpower, 1);
    recipe.AddRecipe();
    
    
