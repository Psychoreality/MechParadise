using System;
using Terraria;
using Terraria.ID;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TerrariaQuickRecipes-Mod
{
    public class MechParadise : Mod
    {
        public MechParadise()
        {
            Properties = new ModProperties()
            {
                Autoload = true
                };
            };
        };

public static class Recipes
{
    public override void AddRecipes()
    {
        

        ModRecipe recipe;

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.ThrowingKnife, 50);
        recipe.AddTile(Terraria.ID.TileID.IronAnvil);
        recipe.SetResult(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.CopperBar, 5);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 50);
        recipe.AddTile(Terraria.ID.TileID.IronAnvil);
        recipe.SetResult(Terraria.ID.ItemID.Wire, 10);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.TinBar, 5);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 50);
        recipe.AddTile(Terraria.ID.TileID.IronAnvil);
        recipe.SetResult(Terraria.ID.ItemID.Wire, 10);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 20);
        recipe.AddIngredient(Terraria.ID.ItemID.VialofVenom, 1);
        recipe.AddTile(Terraria.ID.TileID.IronAnvil);
        recipe.SetResult(Terraria.ID.ItemID.SuperDartTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.DartTrap, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 20);
        recipe.AddIngredient(Terraria.ID.ItemID.Gel, 200);
        recipe.AddTile(Terraria.ID.TileID.IronAnvil);
        recipe.SetResult(Terraria.ID.ItemID.FlameTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.SpikyBall, 200);
        recipe.AddTile(Terraria.ID.TileID.IronAnvil);
        recipe.SetResult(Terraria.ID.ItemID.SpikyBallTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Spike, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.IronBar, 5);
        recipe.AddTile(Terraria.ID.TileID.IronAnvil);
        recipe.SetResult(Terraria.ID.ItemID.SpearTrap, 1);
        recipe.AddRecipe();

        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LihzahrdBrick, 30);
        recipe.AddIngredient(Terraria.ID.ItemID.Spike, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.LeadBar, 5);
        recipe.AddTile(Terraria.ID.TileID.IronAnvil);
        recipe.SetResult(Terraria.ID.ItemID.SpearTrap, 1);
        recipe.AddRecipe();
        
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 50);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.GreaterHealingPotion, 10);
        recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.HeartStatue, 1);
        recipe.AddRecipe();
        
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 50);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.GreaterManaPotion, 10);
        recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.StarStatue, 1);
        recipe.AddRecipe();
        
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.BloodZombieStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.DripplerStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.HopliteStatue, 1);
        recipe.AddRecipe();
        //recipe = new ModRecipe (mod);
        //recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        //recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        //recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        //recipe.SetResult(Terraria.ID.ItemID.VikingStatue, 1);
        //recipe.AddRecipe(); Can't remember what the Viking statue is called
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.HarpyStatue, 1);
        recipe.AddRecipe();
        recipe = new ModRecipe (mod);
        recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        recipe.AddIngredient(Terraria.ID.ItemID.UnicornHorn, 3);
        recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        recipe.SetResult(Terraria.ID.ItemID.UnicornStatue, 1);
        recipe.AddRecipe();
        //recipe = new ModRecipe (mod);
        //recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 100);
        //recipe.AddIngredient(Terraria.ID.ItemID.Wire, 1);
        //recipe.AddIngredient(Terraria.ID.ItemID.KeyofLight, 1);
        //recipe.AddIngredient(Terraria.ID.ItemID.KeyofNight, 1);
        //recipe.AddTile(Terraria.ID.TileID.HeavyWorkBench);
        //recipe.SetResult(Terraria.ID.ItemID.ChestStatue, 1);
        //recipe.AddRecipe(); Keys of Light/Night not working
    
    
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.BandofRegeneration, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.ManaCrystal, 1);
    recipe.AddTile(Terraria.ID.TileID.IronAnvil);
    recipe.SetResult(Terraria.ID.ItemID.BandofStarpower, 1);
    recipe.AddRecipe();
    
    //recipe = new ModRecipe (mod);
    //recipe.AddIngredient(Terraria.ID.ItemID.Actuator, 15);
    //recipe.AddIngredient(Terraria.ID.ItemID.Wire, 5);
    //recipe.AddIngredient(Terraria.ID.ItemID.MechanicalLens, 1);
    //recipe.AddTile(Terraria.ID.TileID.IronAnvil);
    //recipe.SetResult(Terraria.ID.ItemID.Presserator, 1);
    //recipe.AddRecipe();    Commented out until I can work out a way to make Presserator work
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.BandofRegeneration, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.LifeCrystal, 1);
    recipe.AddTile(Terraria.ID.TileID.IronAnvil);
    recipe.SetResult(Terraria.ID.ItemID.PanicNecklace, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.BottledHoney, 10);
    recipe.AddIngredient(Terraria.ID.ItemID.BeeWax, 3);
    recipe.AddTile(Terraria.ID.TileID.IronAnvil);
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
    recipe.AddTile(Terraria.ID.TileID.LihzahrdFurnace);
    recipe.SetResult(Terraria.ID.ItemID.SunStone, 1);
    recipe.AddRecipe();
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.StoneBlock, 500);
    recipe.AddIngredient(Terraria.ID.ItemID.Moonglow, 40);
    recipe.AddIngredient(Terraria.ID.ItemID.SoulofNight, 30);
    recipe.AddTile(Terraria.ID.TileID.LihzahrdFurnace);
    recipe.SetResult(Terraria.ID.ItemID.MoonStone, 1);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.HeartreachPotion, 5);
    recipe.AddIngredient(Terraria.ID.ItemID.LuckyHorseshoe, 1);
    recipe.AddIngredient(Terraria.ID.ItemID.ManaCrystal, 2);
    recipe.AddTile(Terraria.ID.TileID.IronAnvil);
    recipe.SetResult(Terraria.ID.ItemID.CelestialMagnet, 1);
    recipe.AddRecipe();
  
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.PixieDust, 50);
    recipe.AddIngredient(Terraria.ID.ItemID.UnicornHorn, 5);
    recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
    recipe.SetResult(Terraria.ID.ItemID.SoulofLight, 10);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.RottenChunk, 50);
    recipe.AddIngredient(Terraria.ID.ItemID.CursedFlame, 5);
    recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
    recipe.SetResult(Terraria.ID.ItemID.SoulofNight, 10);
    recipe.AddRecipe();
    
    recipe = new ModRecipe (mod);
    recipe.AddIngredient(Terraria.ID.ItemID.Vertebrae, 50);
    recipe.AddIngredient(Terraria.ID.ItemID.Ichor, 5);
    recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
    recipe.SetResult(Terraria.ID.ItemID.SoulofNight, 10);
    recipe.AddRecipe();
  
            recipe = new ModRecipe (mod);
            recipe.AddIngredient(Terraria.ID.ItemID.PrincessFish, 20);
            recipe.AddIngredient(Terraria.ID.ItemID.CrystalShard, 15);
            recipe.AddIngredient(Terraria.ID.ItemID.SoulofLight, 10);
            recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
            recipe.SetResult(Terraria.ID.ItemID.CrystalSerpent, 1);
            recipe.AddRecipe();
            
            recipe = new ModRecipe (mod);
            recipe.AddIngredient(Terraria.ID.ItemID.Ebonkoi, 20);
            recipe.AddIngredient(Terraria.ID.ItemID.SpiderFang, 15);
            recipe.AddIngredient(Terraria.ID.ItemID.SoulofNight, 10);
            recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
            recipe.SetResult(Terraria.ID.ItemID.Toxikarp, 1);
            recipe.AddRecipe();
            
            recipe = new ModRecipe (mod);
            recipe.AddIngredient(Terraria.ID.ItemID.Hemopirahnna, 20);
            recipe.AddIngredient(Terraria.ID.ItemID.Ichor, 15);
            recipe.AddIngredient(Terraria.ID.ItemID.SoulofNight, 10);
            recipe.AddTile(Terraria.ID.TileID.MythrilAnvil);
            recipe.SetResult(Terraria.ID.ItemID.Bladetongue, 1);
            };
            
    };
    
    public static class BossForgeRecipes
    {
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient("Shadowflame", 30);
            recipe.AddIngredient(ItemID.Silk, 10);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.ShadowflameHexDoll, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Shadowflame", 30);
            recipe.AddIngredient(ItemID.ThrowingKnife, 50);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.ShadowflameKnife, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Shadowflame", 30);
            recipe.AddIngredient(ItemID.MoltenFury, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.ShadowflameBow, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fool's Gold", 25);
            recipe.AddIngredient(ItemID.ObsidianSkull, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.PirateStaff, 1);
            recipe.AddRecipe();
            };
        };
        
}

