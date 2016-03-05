﻿using UnityEngine;

namespace ParkitectMods.FlatRides.MagicalTikiHut
{
	public class TikiHut : FlatRide
	{
		public new enum State
		{
			Stopped,
			Running
		}

		[Serialized]
		public State CurrentState;
		[Serialized]
		public float Time;

		public override void Start()
		{
			guestsCanRaiseArms = false;

			CurrentState = State.Stopped;

			/*Transform cars = transform.Find("Cars");

			foreach (Transform car in cars)
			{
				car.gameObject.AddComponent<BumperCar>();
			}

			AudioSource audio = gameObject.AddComponent<AudioSource>();

			if (!GetComponent<BuildableObject>().isPreview || !GetComponent<BuildableObject>().dontSerialize)
			{
				audio.clip = Tune;
				audio.playOnAwake = true;
				audio.loop = true;
				audio.spatialBlend = 0.9f;
				audio.rolloffMode = AudioRolloffMode.Linear;
				audio.maxDistance = 40;
				audio.volume = 0.07f;
				audio.Play();
			}
			else
			{
				audio.playOnAwake = false;
				audio.volume = 0;
			}*/

			base.Start();
		}

		public override void onStartRide()
		{
			base.onStartRide();
			Debug.Log("***OLE! OLE! IT'S CHO-TIME!***");
			CurrentState = State.Running;
		}

		public override void tick(StationController stationController)
		{
			if (CurrentState == State.Running)
			{
				Time += UnityEngine.Time.deltaTime;

				if (Time > 60)
				{
					CurrentState = State.Stopped;
					Time = 0;
				}
			}
		}

		public override bool shouldLetGuestsIn(StationController stationController)
		{
			return CurrentState == State.Stopped;
		}

		public override bool shouldLetGuestsOut()
		{
			return CurrentState == State.Stopped;
		}
	}
}
