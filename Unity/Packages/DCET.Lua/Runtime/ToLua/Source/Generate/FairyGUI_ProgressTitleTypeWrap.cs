﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_ProgressTitleTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.ProgressTitleType));
		L.RegConstant("Percent", FairyGUI.ProgressTitleType.Percent);
		L.RegConstant("ValueAndMax", FairyGUI.ProgressTitleType.ValueAndMax);
		L.RegConstant("Value", FairyGUI.ProgressTitleType.Value);
		L.RegConstant("Max", FairyGUI.ProgressTitleType.Max);
		L.EndEnum();
		TypeTraits<FairyGUI.ProgressTitleType>.Check = CheckType;
		StackTraits<FairyGUI.ProgressTitleType>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.ProgressTitleType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.ProgressTitleType), L, pos);
	}
}

