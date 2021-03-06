﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_RVO_LineWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.RVO.Line), null);
		L.RegFunction("New", _CreatePathfinding_RVO_Line);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("point", get_point, set_point);
		L.RegVar("dir", get_dir, set_dir);
		L.RegFunction("default", __default__);
		L.RegFunction("__clone__", __clone__);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathfinding_RVO_Line(IntPtr L)
	{
		Pathfinding.RVO.Line obj = new Pathfinding.RVO.Line();
		ToLua.PushValue(L, obj);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_point(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.Line obj = (Pathfinding.RVO.Line)o;
			UnityEngine.Vector2 ret = obj.point;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index point on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dir(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.Line obj = (Pathfinding.RVO.Line)o;
			UnityEngine.Vector2 ret = obj.dir;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dir on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_point(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.Line obj = (Pathfinding.RVO.Line)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.point = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index point on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dir(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.Line obj = (Pathfinding.RVO.Line)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.dir = arg0;
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dir on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int __default__(IntPtr L)
	{
		try
		{
			var o = new Pathfinding.RVO.Line();
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
			var obj = (Pathfinding.RVO.Line)ToLua.CheckObject(L, 1, typeof(Pathfinding.RVO.Line));
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

