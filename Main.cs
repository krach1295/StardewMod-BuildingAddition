//This code doesn't work yet--It fails to load the asset because "the specified path doesn't exist." I'm not yet sure how to 
//properly specify a path in this API.

using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;
using xTile.Dimensions;
using xTile.Layers;
using xTile.Tiles;

namespace AddBakery
{
    public class ModEntry : Mod
    {
        IModHelper ourhelper;
        public override void Entry(IModHelper helper)
        {
            ourhelper = helper;
            helper.Events.GameLoop.SaveLoaded += GameLoop_SaveLoaded;
        }

        private void GameLoop_SaveLoaded(object sender, SaveLoadedEventArgs e)
        {
            // This gets the asset key for a tilesheet.png file from your mod's folder.
            string storefrontTilesheetPath = ourhelper.Content.GetActualAssetKey("/bakery_summer.png", ContentSource.ModFolder);
            // Get an instance of the in-game location you want to patch. For the farm, use Game1.getFarm() instead.
            GameLocation location = Game1.getLocationFromName("Town");
            // Add the tilesheet.
            TileSheet springtilesheet = new TileSheet(
                id: "bakery-front-spring", // a unique ID for the tilesheet
                map: location.map,
                imageSource: storefrontTilesheetPath,
                sheetSize: new xTile.Dimensions.Size(128, 160), // the pixel size of your tilesheet image.
                tileSize: new xTile.Dimensions.Size(16, 16) // should always be 16x16 for maps
                );
            location.map.AddTileSheet(springtilesheet);
            location.map.LoadTileSheets(Game1.mapDisplayDevice);



			
		    // remove old tiles from layer
		    location.removeTile(57, 34, "Buildings");
		    location.removeTile(58, 34, "Buildings");
		    location.removeTile(59, 34, "Buildings");
		    location.removeTile(60, 34, "Buildings");
		    location.removeTile(61, 34, "Buildings");
		    location.removeTile(62, 34, "Buildings");
		    location.removeTile(63, 34, "Buildings");
		    location.removeTile(64, 34, "Buildings");
    
		   
		    location.removeTile(57, 35, "Buildings");
		    location.removeTile(58, 35, "Buildings");
		    location.removeTile(59, 35, "Buildings");
		    location.removeTile(60, 35, "Buildings");
		    location.removeTile(61, 35, "Buildings");
		    location.removeTile(62, 35, "Buildings");
		    location.removeTile(63, 35, "Buildings");
		    location.removeTile(64, 35, "Buildings");
 
		   
		    location.removeTile(57, 36, "Buildings");
		    location.removeTile(58, 36, "Buildings");
		    location.removeTile(59, 36, "Buildings");
		    location.removeTile(60, 36, "Buildings");
		    location.removeTile(61, 36, "Buildings");
		    location.removeTile(62, 36, "Buildings");
		    location.removeTile(63, 36, "Buildings");
		    location.removeTile(64, 36, "Buildings");

		   
		    location.removeTile(57, 37, "Buildings");
		    location.removeTile(58, 37, "Buildings");
		    location.removeTile(59, 37, "Buildings");
		    location.removeTile(60, 37, "Buildings");
		    location.removeTile(61, 37, "Buildings");
		    location.removeTile(62, 37, "Buildings");
		    location.removeTile(63, 37, "Buildings");
		    location.removeTile(64, 37, "Buildings");
 
		   
		    location.removeTile(57, 38, "Buildings");
		    location.removeTile(58, 38, "Buildings");
		    location.removeTile(59, 38, "Buildings");
		    location.removeTile(60, 38, "Buildings");
		    location.removeTile(61, 38, "Buildings");
		    location.removeTile(62, 38, "Buildings");
		    location.removeTile(63, 38, "Buildings");
		    location.removeTile(64, 38, "Buildings");
 
		   
		    location.removeTile(57, 39, "Buildings");
		    location.removeTile(58, 39, "Buildings");
		    location.removeTile(59, 39, "Buildings");
		    location.removeTile(60, 39, "Buildings");
		    location.removeTile(61, 39, "Buildings");
		    location.removeTile(62, 39, "Buildings");
		    location.removeTile(63, 39, "Buildings");
		    location.removeTile(64, 39, "Buildings");

		   
		    location.removeTile(57, 40, "Buildings"); 
		    location.removeTile(58, 40, "Buildings");
		    location.removeTile(59, 40, "Buildings");
		    location.removeTile(60, 40, "Buildings");
		    location.removeTile(61, 40, "Buildings");
		    location.removeTile(62, 40, "Buildings");
		    location.removeTile(63, 40, "Buildings");
		    location.removeTile(64, 40, "Buildings");

		   
		    location.removeTile(57, 41, "Buildings");
		    location.removeTile(58, 41, "Buildings");
		    location.removeTile(59, 41, "Buildings");
		    location.removeTile(60, 41, "Buildings");
		    location.removeTile(61, 41, "Buildings");
		    location.removeTile(62, 41, "Buildings");
		    location.removeTile(63, 41, "Buildings");
		    location.removeTile(64, 41, "Buildings");

		   
		    location.removeTile(57, 42, "Buildings");
		    location.removeTile(58, 42, "Buildings");
		    location.removeTile(59, 42, "Buildings");
		    location.removeTile(60, 42, "Buildings");
		    location.removeTile(61, 42, "Buildings");
		    location.removeTile(62, 42, "Buildings");
		    location.removeTile(63, 42, "Buildings");
		    location.removeTile(64, 42, "Buildings");

		   
		    location.removeTile(57, 43, "Buildings");
		    location.removeTile(58, 43, "Buildings");
		    location.removeTile(59, 43, "Buildings");
		    location.removeTile(60, 43, "Buildings");
		    location.removeTile(61, 43, "Buildings");
		    location.removeTile(62, 43, "Buildings");
		    location.removeTile(63, 43, "Buildings");
		    location.removeTile(64, 43, "Buildings");
 
		    // add new tiles
		    Layer layer = location.map.GetLayer("Buildings");
            TileSheet tilesheet = location.map.GetTileSheet("springtilesheet");


            layer.Tiles[57, 34] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 0);
            layer.Tiles[58, 34] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 1);
            layer.Tiles[59, 34] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 2);
            layer.Tiles[60, 34] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 3);
            layer.Tiles[61, 34] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 4);
            layer.Tiles[62, 34] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 5);
            layer.Tiles[63, 34] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 6);
            layer.Tiles[64, 34] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 7);


            layer.Tiles[57, 35] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 8);
            layer.Tiles[58, 35] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 9);
            layer.Tiles[59, 35] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 10);
            layer.Tiles[60, 35] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 11);
            layer.Tiles[61, 35] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 12);
            layer.Tiles[62, 35] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 13);
            layer.Tiles[63, 35] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 14);
            layer.Tiles[64, 35] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 15);

            layer.Tiles[57, 36] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 16);
            layer.Tiles[58, 36] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 17);
            layer.Tiles[59, 36] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 18);
            layer.Tiles[60, 36] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 19);
            layer.Tiles[61, 36] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 20);
            layer.Tiles[62, 36] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 21);
            layer.Tiles[63, 36] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 22);
            layer.Tiles[64, 36] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 23);

            layer.Tiles[57, 37] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 24);
            layer.Tiles[58, 37] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 25);
            layer.Tiles[59, 37] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 26);
            layer.Tiles[60, 37] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 27);
            layer.Tiles[61, 37] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 28);
            layer.Tiles[62, 37] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 29);
            layer.Tiles[63, 37] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 30);
            layer.Tiles[64, 37] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 31);

            layer.Tiles[57, 38] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 32);
            layer.Tiles[58, 38] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 33);
            layer.Tiles[59, 38] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 34);
            layer.Tiles[60, 38] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 35);
            layer.Tiles[61, 38] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 36);
            layer.Tiles[62, 38] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 37);
            layer.Tiles[63, 38] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 38);
            layer.Tiles[64, 38] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 39);

            layer.Tiles[57, 39] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 40);
            layer.Tiles[58, 39] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 41);
            layer.Tiles[59, 39] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 42);
            layer.Tiles[60, 39] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 43);
            layer.Tiles[61, 39] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 44);
            layer.Tiles[62, 39] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 45);
            layer.Tiles[63, 39] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 46);
            layer.Tiles[64, 39] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 47);

            layer.Tiles[57, 40] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 48);
            layer.Tiles[58, 40] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 49);
            layer.Tiles[59, 40] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 50);
            layer.Tiles[60, 40] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 51);
            layer.Tiles[61, 40] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 52);
            layer.Tiles[62, 40] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 53);
            layer.Tiles[63, 40] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 54);
            layer.Tiles[64, 40] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 55);

            layer.Tiles[57, 41] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 56);
            layer.Tiles[58, 41] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 57);
            layer.Tiles[59, 41] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 58);
            layer.Tiles[60, 41] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 59);
            layer.Tiles[61, 41] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 60);
            layer.Tiles[62, 41] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 61);
            layer.Tiles[63, 41] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 62);
            layer.Tiles[64, 41] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 63);

            layer.Tiles[57, 42] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 64);
            layer.Tiles[58, 42] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 65);
            layer.Tiles[59, 42] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 66);
            layer.Tiles[60, 42] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 67);
            layer.Tiles[61, 42] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 68);
            layer.Tiles[62, 42] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 69);
            layer.Tiles[63, 42] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 70);
            layer.Tiles[64, 42] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 71);

            layer.Tiles[57, 43] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 72);
            layer.Tiles[58, 43] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 73);
            layer.Tiles[59, 43] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 74);
            layer.Tiles[60, 43] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 75);
            layer.Tiles[61, 43] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 76);
            layer.Tiles[62, 43] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 77);
            layer.Tiles[63, 43] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 78);
            layer.Tiles[64, 43] = new StaticTile(layer, tilesheet, BlendMode.Alpha, 79);
        }
    }
}
