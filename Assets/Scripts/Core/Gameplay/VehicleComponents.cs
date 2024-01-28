﻿using System;
using Scellecs.Morpeh;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Core.Gameplay
{
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	[Serializable]
	public struct VehicleConfigComponent : IComponent
	{
		public VehicleConfig Reference;
	}
	
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	[Serializable]
	public struct Wheels : IComponent
	{
		public WheelCollider FrontLeftWheel;
		public WheelCollider FrontRightWheel;
		public WheelCollider RearLeftWheel;
		public WheelCollider RearRightWheel;
	}
	
	[Il2CppSetOption(Option.NullChecks, false)]
	[Il2CppSetOption(Option.ArrayBoundsChecks, false)]
	[Il2CppSetOption(Option.DivideByZeroChecks, false)]
	[Serializable]
	public struct WheelMeshes : IComponent
	{
		public Transform FrontLeftWheelMesh;
		public Transform FrontRightWheelMesh;
		public Transform RearLeftWheelMesh;
		public Transform RearRightWheelMesh;
	}
}