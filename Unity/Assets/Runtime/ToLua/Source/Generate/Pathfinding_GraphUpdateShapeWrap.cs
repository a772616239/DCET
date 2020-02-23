﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_GraphUpdateShapeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.GraphUpdateShape), typeof(System.Object));
		L.RegFunction("GetBounds", GetBounds);
		L.RegFunction("Contains", Contains);
		L.RegFunction("New", _CreatePathfinding_GraphUpdateShape);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("minimumHeight", get_minimumHeight, set_minimumHeight);
		L.RegVar("points", get_points, set_points);
		L.RegFunction("getpoints", get_points);
		L.RegFunction("setpoints", set_points);
		L.RegVar("convex", get_convex, set_convex);
		L.RegFunction("getconvex", get_convex);
		L.RegFunction("setconvex", set_convex);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathfinding_GraphUpdateShape(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Pathfinding.GraphUpdateShape obj = new Pathfinding.GraphUpdateShape();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 4)
			{
				UnityEngine.Vector3[] arg0 = ToLua.CheckStructArray<UnityEngine.Vector3>(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				UnityEngine.Matrix4x4 arg2 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 3);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 4);
				Pathfinding.GraphUpdateShape obj = new Pathfinding.GraphUpdateShape(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Pathfinding.GraphUpdateShape.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetBounds(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)ToLua.CheckObject<Pathfinding.GraphUpdateShape>(L, 1);
				UnityEngine.Bounds o = obj.GetBounds();
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Vector3[] arg0 = ToLua.CheckStructArray<UnityEngine.Vector3>(L, 1);
				UnityEngine.Matrix4x4 arg1 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 2);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Bounds o = Pathfinding.GraphUpdateShape.GetBounds(arg0, arg1, arg2);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.GraphUpdateShape.GetBounds");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Contains(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<PF.GraphNode>(L, 2))
			{
				Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)ToLua.CheckObject<Pathfinding.GraphUpdateShape>(L, 1);
				PF.GraphNode arg0 = (PF.GraphNode)ToLua.ToObject(L, 2);
				bool o = obj.Contains(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Vector3>(L, 2))
			{
				Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)ToLua.CheckObject<Pathfinding.GraphUpdateShape>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				bool o = obj.Contains(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.GraphUpdateShape.Contains");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_minimumHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)o;
			float ret = obj.minimumHeight;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index minimumHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_points(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)o;
			UnityEngine.Vector3[] ret = obj.points;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index points on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_convex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)o;
			bool ret = obj.convex;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index convex on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_minimumHeight(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.minimumHeight = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index minimumHeight on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_points(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)o;
			UnityEngine.Vector3[] arg0 = ToLua.CheckStructArray<UnityEngine.Vector3>(L, 2);
			obj.points = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index points on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_convex(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.GraphUpdateShape obj = (Pathfinding.GraphUpdateShape)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.convex = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index convex on a nil value");
		}
	}
}
