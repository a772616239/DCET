﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_WindowsStoreCompatibilityWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("WindowsStoreCompatibility");
		L.RegFunction("GetTypeFromInfo", GetTypeFromInfo);
		L.RegFunction("GetTypeInfo", GetTypeInfo);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTypeFromInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			System.Type o = PF.WindowsStoreCompatibility.GetTypeFromInfo(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTypeInfo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			System.Type arg0 = ToLua.CheckMonoType(L, 1);
			System.Type o = PF.WindowsStoreCompatibility.GetTypeInfo(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

