﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_StartEndModifier_ExactnessWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(Pathfinding.StartEndModifier.Exactness));
		L.RegConstant("SnapToNode", Pathfinding.StartEndModifier.Exactness.SnapToNode);
		L.RegConstant("Original", Pathfinding.StartEndModifier.Exactness.Original);
		L.RegConstant("Interpolate", Pathfinding.StartEndModifier.Exactness.Interpolate);
		L.RegConstant("ClosestOnNode", Pathfinding.StartEndModifier.Exactness.ClosestOnNode);
		L.RegConstant("NodeConnection", Pathfinding.StartEndModifier.Exactness.NodeConnection);
		L.EndEnum();
		TypeTraits<Pathfinding.StartEndModifier.Exactness>.Check = CheckType;
		StackTraits<Pathfinding.StartEndModifier.Exactness>.Push = Push;
	}

	static void Push(IntPtr L, Pathfinding.StartEndModifier.Exactness arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(Pathfinding.StartEndModifier.Exactness), L, pos);
	}
}

