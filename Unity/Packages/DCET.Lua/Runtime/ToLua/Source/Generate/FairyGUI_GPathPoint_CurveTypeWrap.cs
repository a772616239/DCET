﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_GPathPoint_CurveTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.GPathPoint.CurveType));
		L.RegConstant("CRSpline", FairyGUI.GPathPoint.CurveType.CRSpline);
		L.RegConstant("Bezier", FairyGUI.GPathPoint.CurveType.Bezier);
		L.RegConstant("CubicBezier", FairyGUI.GPathPoint.CurveType.CubicBezier);
		L.RegConstant("Straight", FairyGUI.GPathPoint.CurveType.Straight);
		L.EndEnum();
		TypeTraits<FairyGUI.GPathPoint.CurveType>.Check = CheckType;
		StackTraits<FairyGUI.GPathPoint.CurveType>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.GPathPoint.CurveType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.GPathPoint.CurveType), L, pos);
	}
}

