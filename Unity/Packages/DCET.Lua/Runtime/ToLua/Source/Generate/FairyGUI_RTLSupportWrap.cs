﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_RTLSupportWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.RTLSupport), typeof(System.Object));
		L.RegFunction("IsArabicLetter", IsArabicLetter);
		L.RegFunction("ContainsArabicLetters", ContainsArabicLetters);
		L.RegFunction("DetectTextDirection", DetectTextDirection);
		L.RegFunction("DoMapping", DoMapping);
		L.RegFunction("ConvertLineL", ConvertLineL);
		L.RegFunction("ConvertLineR", ConvertLineR);
		L.RegFunction("New", _CreateFairyGUI_RTLSupport);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("BaseDirection", get_BaseDirection, set_BaseDirection);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_RTLSupport(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.RTLSupport obj = new FairyGUI.RTLSupport();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.RTLSupport.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsArabicLetter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			char arg0 = (char)LuaDLL.luaL_checknumber(L, 1);
			bool o = FairyGUI.RTLSupport.IsArabicLetter(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ContainsArabicLetters(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = FairyGUI.RTLSupport.ContainsArabicLetters(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DetectTextDirection(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			FairyGUI.RTLSupport.DirectionType o = FairyGUI.RTLSupport.DetectTextDirection(arg0);
			LuaDLL.lua_pushinteger(L, (int)o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoMapping(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = FairyGUI.RTLSupport.DoMapping(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConvertLineL(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = FairyGUI.RTLSupport.ConvertLineL(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ConvertLineR(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			string o = FairyGUI.RTLSupport.ConvertLineR(arg0);
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_BaseDirection(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)FairyGUI.RTLSupport.BaseDirection);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_BaseDirection(IntPtr L)
	{
		try
		{
			FairyGUI.RTLSupport.DirectionType arg0 = (FairyGUI.RTLSupport.DirectionType)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.RTLSupport.BaseDirection = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

