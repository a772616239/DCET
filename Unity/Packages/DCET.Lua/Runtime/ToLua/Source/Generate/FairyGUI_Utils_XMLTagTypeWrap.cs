﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_Utils_XMLTagTypeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FairyGUI.Utils.XMLTagType));
		L.RegConstant("Start", FairyGUI.Utils.XMLTagType.Start);
		L.RegConstant("End", FairyGUI.Utils.XMLTagType.End);
		L.RegConstant("Void", FairyGUI.Utils.XMLTagType.Void);
		L.RegConstant("CDATA", FairyGUI.Utils.XMLTagType.CDATA);
		L.RegConstant("Comment", FairyGUI.Utils.XMLTagType.Comment);
		L.RegConstant("Instruction", FairyGUI.Utils.XMLTagType.Instruction);
		L.EndEnum();
		TypeTraits<FairyGUI.Utils.XMLTagType>.Check = CheckType;
		StackTraits<FairyGUI.Utils.XMLTagType>.Push = Push;
	}

	static void Push(IntPtr L, FairyGUI.Utils.XMLTagType arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FairyGUI.Utils.XMLTagType), L, pos);
	}
}

