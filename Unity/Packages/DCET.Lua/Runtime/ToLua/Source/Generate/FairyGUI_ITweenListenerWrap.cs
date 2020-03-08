﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_ITweenListenerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.ITweenListener), null);
		L.RegFunction("OnTweenStart", OnTweenStart);
		L.RegFunction("OnTweenUpdate", OnTweenUpdate);
		L.RegFunction("OnTweenComplete", OnTweenComplete);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnTweenStart(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.ITweenListener obj = (FairyGUI.ITweenListener)ToLua.CheckObject<FairyGUI.ITweenListener>(L, 1);
			FairyGUI.GTweener arg0 = (FairyGUI.GTweener)ToLua.CheckObject<FairyGUI.GTweener>(L, 2);
			obj.OnTweenStart(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnTweenUpdate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.ITweenListener obj = (FairyGUI.ITweenListener)ToLua.CheckObject<FairyGUI.ITweenListener>(L, 1);
			FairyGUI.GTweener arg0 = (FairyGUI.GTweener)ToLua.CheckObject<FairyGUI.GTweener>(L, 2);
			obj.OnTweenUpdate(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnTweenComplete(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FairyGUI.ITweenListener obj = (FairyGUI.ITweenListener)ToLua.CheckObject<FairyGUI.ITweenListener>(L, 1);
			FairyGUI.GTweener arg0 = (FairyGUI.GTweener)ToLua.CheckObject<FairyGUI.GTweener>(L, 2);
			obj.OnTweenComplete(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
