﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_TransitionActionTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.TransitionActionType));
		L.RegConstant("XY", FairyGUI.TransitionActionType.XY);
		L.RegConstant("Size", FairyGUI.TransitionActionType.Size);
		L.RegConstant("Scale", FairyGUI.TransitionActionType.Scale);
		L.RegConstant("Pivot", FairyGUI.TransitionActionType.Pivot);
		L.RegConstant("Alpha", FairyGUI.TransitionActionType.Alpha);
		L.RegConstant("Rotation", FairyGUI.TransitionActionType.Rotation);
		L.RegConstant("Color", FairyGUI.TransitionActionType.Color);
		L.RegConstant("Animation", FairyGUI.TransitionActionType.Animation);
		L.RegConstant("Visible", FairyGUI.TransitionActionType.Visible);
		L.RegConstant("Sound", FairyGUI.TransitionActionType.Sound);
		L.RegConstant("Transition", FairyGUI.TransitionActionType.Transition);
		L.RegConstant("Shake", FairyGUI.TransitionActionType.Shake);
		L.RegConstant("ColorFilter", FairyGUI.TransitionActionType.ColorFilter);
		L.RegConstant("Skew", FairyGUI.TransitionActionType.Skew);
		L.RegConstant("Text", FairyGUI.TransitionActionType.Text);
		L.RegConstant("Icon", FairyGUI.TransitionActionType.Icon);
		L.RegConstant("Unknown", FairyGUI.TransitionActionType.Unknown);
		L.EndEnum();
		TypeTraits<FairyGUI.TransitionActionType>.Check = CheckType;
		StackTraits<FairyGUI.TransitionActionType>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.TransitionActionType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.TransitionActionType), L, pos);
	}
}

