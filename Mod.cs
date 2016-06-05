using System;
using Terraria;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;

public static class Recipes
{
    public static void TrapRecipes (Mod mod)
    {
        

        ModRecipe recipe;

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.ThrowingKnife, 50);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.CopperBar, 5);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 50);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.Wire, 10);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.TinBar, 5);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 50);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.Wire, 10);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 20);
        recipe.AddIngredient(Terraria.ID.ItemID.VialofVenom, 1);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.SuperDartTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 20);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 200);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.FlameTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.SpikyBall, 200);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.SpikyBallTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Spike, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.IronBar, 5);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.SpearTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Spike, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LeadBar, 5);
        recipe.AddTile(Terraria.ID.TileID.TinkerersWorkshop);
        recipe.SetResult(Terraria.ID.ItemID.SpearTrap, 1);
        recipe.AddRecipe();
        
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 50);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.GreaterHealingPotion, 10);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.HeartStatue, 1);
        recipe.AddRecipe();
        
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 50);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.GreaterManaPotion, 10);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.StarStatue, 1);
        recipe.AddRecipe();
        
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.BloodZombieStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.DripplerStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.HopliteStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.VikingStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.HarpyStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.UnicornHorn, 3);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.UnicornStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.KeyofLight, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.KeyofNight, 1);
        recipe.AddTile(Terraria.ID.ItemID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.ChestStatue, 1);
        recipe.AddRecipe();
            }
    


public static void EquipRecipes (Mod mod)
{
    ModRecipe recipe;
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.BandofRegeneration, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.ManaCrystal, 1);
    recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    recipe.SetResult(Terraria.ID.ItemID.BandofStarpower, 1);
    recipe.AddRecipe();
    
    //recipe = new ModRecipe (mod);
    //recipe.AddIngredient(Terraria.ID.ItemID.Actuator, 15);
    //recipe.AddIngredient(Terraria.ID.ItemID.Wire, 5);
    //recipe.AddIngredient(Terraria.ID.ItemID.MechanicalLens, 1);
    //recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    //recipe.SetResult(Terraria.ID.ItemID.Presserator, 1);
    //recipe.AddRecipe();    Commented out until I can work out a way to make Presserator work
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.BandofRegeneration, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LifeCrystal, 1);
    recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    recipe.SetResult(Terraria.ID.ItemID.PanicNecklace, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.BottledHoney, 10);
    recipe.AddIngredient(Terraria.ID.ItemID.BeeWax, 3);
    recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    recipe.SetResult(Terraria.ID.ItemID.HoneyComb, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.WarriorEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.RangerEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.WarriorEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.SorcererEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.WarriorEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.SummonerEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.RangerEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.WarriorEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.RangerEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.SorcererEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.RangerEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.SummonerEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.SorcererEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.WarriorEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.SorcererEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.RangerEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.SorcererEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.SummonerEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.SummonerEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.WarriorEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.SummonerEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.RangerEmblem, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.SummonerEmblem, 1);
    recipe.SetResult(Terraria.ID.ItemID.SorcererEmblem, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 500);
    recipe.AddIngredient(Terraria.ID.ItemID.Daybloom, 40);
    recipe.AddIngredient(Terraria.ID.ItemID.SoulofLight, 30);
    recipe.AddTile(Terraria.ID.ItemID.LihzahrdFurnace);
    recipe.SetResult(Terraria.ID.ItemID.SunStone, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 500);
    recipe.AddIngredient(Terraria.ID.ItemID.Moonglow, 40);
    recipe.AddIngredient(Terraria.ID.ItemID.SoulofNight, 30);
    recipe.AddTile(Terraria.ID.ItemID.LihzahrdFurnace);
    recipe.SetResult(Terraria.ID.ItemID.MoonStone, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.HeartreachPotion, 5);
    recipe.AddIngredient(Terraria.ID.ItemID.LuckyHorseshoe, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.ManaCrystal, 2);
    recipe.AddTile(Terraria.ID.ItemID.TinkerersWorkshop);
    recipe.SetResult(Terraria.ID.ItemID.CelestialMagnet, 1);
    recipe.AddRecipe();
    }
    
    public static void Souls (Mod mod)
    {
    ModRecipe recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.PixieDust, 50);
    recipe.AddIngredient(Terraria.ID.ItemID.UnicornHorn, 5);
    recipe.AddTile(Terraria.ID.ItemID.MythrilAnvil);
    recipe.SetResult(Terraria.ID.ItemID.SoulofLight, 10);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.RottenChunk, 50);
    recipe.AddIngredient(Terraria.ID.ItemID.CursedFlame, 5);
    recipe.AddTile(Terraria.ID.ItemID.MythrilAnvil);
    recipe.SetResult(Terraria.ID.ItemID.SoulofNight, 10);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIgnredient(Terraria.ID.ItemID.Vertebrae, 50);
    recipe.AddIngredient(Terraria.ID.ItemID.Ichor, 5);
    recipe.AddTile(Terraria.ID.ItemID.MythrilAnvil);
    recipe.SetResult(Terraria.ID.ItemID.SoulofNight, 10);
    recipe.AddRecipe();
        }
    }
