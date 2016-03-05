using UnityEngine;

namespace ParkitectMods.FlatRides.MagicalTikiHut
{
	public class TikiHutLoader : FlatRideLoader
	{
		protected override GameObject LoadRideData()
		{
			GameObject asset = GameObject.CreatePrimitive(PrimitiveType.Cube);

			TikiHut tikiHut = asset.AddComponent<TikiHut>();

			/*SetColors(asset, new[]
			{
				ConvertColor(161, 1, 1),
				ConvertColor(220, 205, 7),
				ConvertColor(112, 112, 112),
				ConvertColor(76, 76, 76)
			});*/

			BasicFlatRideSettings(tikiHut, "Magical Tiki Hut", 600, .8f, .2f, .1f, 6, 6);
			return asset;
		}
	}
}

