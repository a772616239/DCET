﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_MarginWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.Margin), null);
		L.RegFunction("New", _CreateFairyGUI_Margin);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("left", get_left, set_left);
		L.RegVar("right", get_right, set_right);
		L.RegVar("top", get_top, set_top);
		L.RegVar("bottom", get_bottom, set_bottom);
		L.RegFunction("default", __default__);
		L.RegFunction("__clone__", __clone__);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_Margin(IntPtr L)
	{
		FairyGUI.Margin obj = new FairyGUI.Margin();
		ToLua.PushValue(L, obj);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_left(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Margin obj = (FairyGUI.Margin)o;
			int ret = obj.left;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index left on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_right(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Margin obj = (FairyGUI.Margin)o;
			int ret = obj.right;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index right on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_top(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Margin obj = (FairyGUI.Margin)o;
			int ret = obj.top;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index top on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_bottom(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Margin obj = (FairyGUI.Margin)o;
			int ret = obj.bottom;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bottom on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_left(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Margin obj = (FairyGUI.Margin)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.left = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index left on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_right(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Margin obj = (FairyGUI.Margin)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.right = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index right on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_top(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Margin obj = (FairyGUI.Margin)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.top = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index top on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_bottom(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Margin obj = (FairyGUI.Margin)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.bottom = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index bottom on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int __default__(IntPtr L)
	{
		try
		{
			var o = new FairyGUI.Margin();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int __clone__(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			var obj = (FairyGUI.Margin)ToLua.CheckObject(L, 1, typeof(FairyGUI.Margin));
			var o = obj;
			ToLua.PushValue(L, o);
			ToLua.SetBack(L, 1, obj);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

