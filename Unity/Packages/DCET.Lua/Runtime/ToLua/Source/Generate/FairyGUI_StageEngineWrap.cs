﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_StageEngineWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.StageEngine), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("ObjectsOnStage", get_ObjectsOnStage, set_ObjectsOnStage);
		L.RegVar("GraphicsOnStage", get_GraphicsOnStage, set_GraphicsOnStage);
		L.RegVar("beingQuit", get_beingQuit, set_beingQuit);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ObjectsOnStage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageEngine obj = (FairyGUI.StageEngine)o;
			int ret = obj.ObjectsOnStage;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ObjectsOnStage on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GraphicsOnStage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageEngine obj = (FairyGUI.StageEngine)o;
			int ret = obj.GraphicsOnStage;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index GraphicsOnStage on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_beingQuit(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, FairyGUI.StageEngine.beingQuit);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ObjectsOnStage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageEngine obj = (FairyGUI.StageEngine)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.ObjectsOnStage = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ObjectsOnStage on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_GraphicsOnStage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.StageEngine obj = (FairyGUI.StageEngine)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.GraphicsOnStage = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index GraphicsOnStage on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_beingQuit(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			FairyGUI.StageEngine.beingQuit = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

