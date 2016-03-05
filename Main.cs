using UnityEngine;

namespace ParkitectMods.FlatRides.MagicalTikiHut
{
	public class Main : IMod
	{
		private GameObject _go;

		public void onEnabled()
		{
			_go = new GameObject();

			_go.AddComponent<TikiHutLoader>();
			//_go.GetComponent<TikiHutLoader>().Path = Path;
			//_go.GetComponent<TikiHutLoader>().Identifier = Identifier;
			_go.GetComponent<TikiHutLoader>().LoadFlatRide();
		}

		public void onDisabled()
		{
			_go.GetComponent<TikiHutLoader>().UnloadScenery();

			Object.Destroy(_go);
		}

		/// <summary>
		///     Gets the name of this instance.
		/// </summary>
		public string Name
		{
			get
			{
				return "The Magical Tiki Hut";
			}
		}

		/// <summary>
		///     Gets the description of this instance.
		/// </summary>
		public string Description
		{
			get
			{
				return "A place where the fowls sing vowels and the plants hum tunes.";
			}
		}

		private string _identifier;
		/// <summary>
		///     Gets an unique identifier of this mod.
		/// <summary>
		public string Identifier
		{
			get
			{
				return _identifier;
			}
			set
			{
				_identifier = value;
			}
		}

		private string _path;
		public string Path
		{
			get
			{
				return _path;
			}
			set
			{
				_path = value;
			}
		}
	}
}