﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DCETRuntime_PathHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("PathHelper");
		L.RegVar("AppHotfixResPath", get_AppHotfixResPath, null);
		L.RegFunction("getAppHotfixResPath", get_AppHotfixResPath);
		L.RegVar("AppResPath", get_AppResPath, null);
		L.RegFunction("getAppResPath", get_AppResPath);
		L.RegVar("AppResPath4Web", get_AppResPath4Web, null);
		L.RegFunction("getAppResPath4Web", get_AppResPath4Web);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppHotfixResPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, DCETRuntime.PathHelper.AppHotfixResPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppResPath(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, DCETRuntime.PathHelper.AppResPath);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AppResPath4Web(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, DCETRuntime.PathHelper.AppResPath4Web);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

