﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_DestroyMethodWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.DestroyMethod));
		L.RegConstant("Destroy", FairyGUI.DestroyMethod.Destroy);
		L.RegConstant("Unload", FairyGUI.DestroyMethod.Unload);
		L.RegConstant("None", FairyGUI.DestroyMethod.None);
		L.EndEnum();
		TypeTraits<FairyGUI.DestroyMethod>.Check = CheckType;
		StackTraits<FairyGUI.DestroyMethod>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.DestroyMethod arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.DestroyMethod), L, pos);
	}
}

