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
    
    recipe = new ModRecipe(mod);
    recipe.AddIngredient(ItemID.SoulofLight, 200);
    recipe.AddIngredient(ItemID.CrystalShard, 99);
    recipe.AddIngredient(ItemID.SoulofSight, 20);
    recipe.AddTile(TileID.MythrilAnvil);
    recipe.SetResult(ItemID.RodofDiscord, 1);
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
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fool's Gold", 150);
            recipe.AddIngredient(ItemID.LuckyHorseshoe, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.LuckyCoin, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fool's Gold", 20);
            recipe.AddIngredient(ItemID.DiamondRing, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.GoldRing, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fool's Gold", 50);
            recipe.AddIngredient(ItemID.Wood, 10);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.DiscountCard);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Martian Energy Core", 1);
            recipe.AddIngredient(ItemID.Drax, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.LaserDrill, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Martian Energy Core", 1);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.InfluxWaver);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Martian Energy Core", 1);
            recipe.AddIngredient(ItemID.Bubble, 20);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.Xenopopper, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Martian Energy Core", 1);
            recipe.AddIngredient(ItemID.Glass, 20);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.LaserMachinegun, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Martian Energy Core", 1);
            recipe.AddIngredient(ItemID.Glass, 20);
            recipe.AddIngredient(ItemID.Ectoplasm, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.ChargedBlasterCannon, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Martian Energy Core", 1);
            recipe.AddIngredient(ItemID.FallenStar, 10);
            recipe.AddIngredient(ItemID.MeteoriteBar, 15);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.XenoStaff, 1);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddIngredient(ItemID.BottledHoney, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.BeeKeeper, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddIngredient(ItemID.BottledHoney, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.BeeGun, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeeWax, 5);
            recipe.AddIngredient(ItemID.BottledHoney, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.TheBee'sKnees, 1);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Unhallowed Shard", 10);
            recipe.AddIngredient(ItemID.SpaceGun, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.LaserRifle, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Unhallowed Shard", 10);
            recipe.AddIngredient(ItemID.SoulofNight, 3);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.BreakerBlade, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Unhallowed Shard", 10);
            recipe.AddIngredient(ItemID.Musket, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.ClockworkAssaultRifle);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fishron Scale", 3);
            recipe.AddIngredient(ItemID.Bubble, 50);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.BubbleGun, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fishron Scale", 3);
            recipe.AddIngredient(ItemID.MagnetSphere, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.RazorbladeTyphoon, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fishron Scale", 3);
            recipe.AddIngredient(ItemID.Chain, 5);
            recipe.AddIngredient(ItemID.Bubble, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.Flairon, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fishron Scale", 3);
            recipe.AddIngredient(ItemID.ShroomiteBar, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.Tsunami, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fishron Scale", 3);
            recipe.AddIngredient(ItemID.SharkFin, 10);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.TempestStaff);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Fishron Scale", 6);
            recipe.AddIngredient(ItemID.SoulofFlight, 20);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.FishronWings);
            recipe.AddRecipe();
            
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.SharkFin, 5);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.SDMG, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.CrystalShard, 50);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.RainbowCrystalStaff, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.WoodenYoyo, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.Terrarian, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.Starfury, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.StarWrath, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.UnicornHorn, 5);
            recipe.AddIngredient(ItemID.PixieDust, 25);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.Meowmere, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.RocketIII, 20);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.Celebration, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.SoulofNight, 15);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.LunarPortalStaff, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.Book, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.LunarFlare, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe (mod);
            recipe.AddIngredient("Lunar Heart", 1);
            recipe.AddIngredient(ItemID.LuminiteBar, 10);
            recipe.AddIngredient(ItemID.SoulofLight, 15);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.LastPrism, 1);
            recipe.AddRecipe();
            
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Heavy Petal", 5);
            recipe.AddIngredient(ItemID.BeeGun, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.WaspGun, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Heavy Petal", 5);
            recipe.AddIngredient(ItemID.BladeofGrass, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.Seedler, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Heavy Petal", 5);
            recipe.AddIngredient(ItemID.Vilethorn, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.NettleBurst, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Heavy Petal", 5);
            recipe.AddIngredient(ItemID.CrimsonRod, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.NettleBurst, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Heavy Petal", 5);
            recipe.AddIngredient(ItemID.PirateStaff, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.PygmyStaff, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Heavy Petal", 5);
            recipe.AddIngredient(ItemID.BlueMoon, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.FlowerPow, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Heavy Petal", 5);
            recipe.AddIngredient(ItemID.RichMahogany, 40);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.LeafBlower, 1);
            recipe.AddRecipe();
            recipe = new ModRecipe(mod);
            recipe.AddIngredient("Heavy Petal", 25);
            recipe.AddIngredient(ItemID.MeteorHamaxe, 1);
            recipe.AddTile(null, "Ultimate Loot Reconstructor");
            recipe.SetResult(ItemID.TheAxe, 1);
            recipe.AddRecipe();
            };
        };
        
}

