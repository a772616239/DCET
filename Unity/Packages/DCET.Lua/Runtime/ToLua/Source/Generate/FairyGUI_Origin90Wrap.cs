﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_Origin90Wrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.Origin90));
		L.RegConstant("TopLeft", FairyGUI.Origin90.TopLeft);
		L.RegConstant("TopRight", FairyGUI.Origin90.TopRight);
		L.RegConstant("BottomLeft", FairyGUI.Origin90.BottomLeft);
		L.RegConstant("BottomRight", FairyGUI.Origin90.BottomRight);
		L.EndEnum();
		TypeTraits<FairyGUI.Origin90>.Check = CheckType;
		StackTraits<FairyGUI.Origin90>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.Origin90 arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.Origin90), L, pos);
	}
}

