using Terraria;
using Terraria.ModLoader;

namespace TerrariaQuickRecipes-Mod.Tiles
{
    public class BossForge : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolidTop[Type] = false;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = false;
			Main.tileLavaDeath[Type] = false;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.CoordinateHeights = new int[]{ 30 };
			TileObjectData.addTile(Type);
			AddMapEntry(new Color(200, 200, 200), "Ultimate Loot Reconstructor");
			disableSmartCursor = true;
		}
            public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 26, j * 26, 30, 26, mod.ItemType("BossForge"));
		}
	}
}