﻿using Core.CameraLogic;
using Core.Gameplay;
using Scellecs.Morpeh;
using UnityEngine;

namespace Core.ECS
{
	public static class EntityExtensions
	{
		public static void TryRemove<T>(this Entity entity) where T : struct, IComponent
		{
			if (entity.Has<T>())
				entity.RemoveComponent<T>();
		}

		public static Entity GetPlayer(this World world) => 
			world.Filter.With<HumanPlayer>().Build().First();

		public static void AddPrefab(this Entity entity, string name) => 
			entity.SetComponent(new Prefab { Value = name });

		public static void ChangeDurability(this Entity entity, float newDurability)
		{
			ref var durability = ref entity.GetComponent<Durability>();
			durability.Value = newDurability;
			if (!entity.Has<DurabilityChanged>())
				entity.SetComponent(new DurabilityChanged());
		}

		public static void ChangeActiveCamera(this World world, string cameraName)
		{
			var camera = world.Filter.With<CurrentVirtualCamera>().Build().First();
			ref var current = ref camera.GetComponent<CurrentVirtualCamera>();
			current.Value = cameraName;
			Debug.Log(current.Value);
			camera.SetComponent(new CurrentVirtualCameraChanged());
		}
	}
}