﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_FitScreenWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.FitScreen));
		L.RegConstant("None", FairyGUI.FitScreen.None);
		L.RegConstant("FitSize", FairyGUI.FitScreen.FitSize);
		L.RegConstant("FitWidthAndSetMiddle", FairyGUI.FitScreen.FitWidthAndSetMiddle);
		L.RegConstant("FitHeightAndSetCenter", FairyGUI.FitScreen.FitHeightAndSetCenter);
		L.EndEnum();
		TypeTraits<FairyGUI.FitScreen>.Check = CheckType;
		StackTraits<FairyGUI.FitScreen>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.FitScreen arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.FitScreen), L, pos);
	}
}

