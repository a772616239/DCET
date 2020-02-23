﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_Util_DrawWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.Util.Draw), typeof(System.Object));
		L.RegFunction("Line", Line);
		L.RegFunction("CircleXZ", CircleXZ);
		L.RegFunction("Cylinder", Cylinder);
		L.RegFunction("CrossXZ", CrossXZ);
		L.RegFunction("Bezier", Bezier);
		L.RegFunction("New", _CreatePathfinding_Util_Draw);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Debug", get_Debug, null);
		L.RegVar("Gizmos", get_Gizmos, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathfinding_Util_Draw(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				Pathfinding.Util.Draw obj = new Pathfinding.Util.Draw();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Pathfinding.Util.Draw.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Line(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Pathfinding.Util.Draw obj = (Pathfinding.Util.Draw)ToLua.CheckObject<Pathfinding.Util.Draw>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			UnityEngine.Color arg2 = ToLua.ToColor(L, 4);
			obj.Line(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CircleXZ(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 4)
			{
				Pathfinding.Util.Draw obj = (Pathfinding.Util.Draw)ToLua.CheckObject<Pathfinding.Util.Draw>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Color arg2 = ToLua.ToColor(L, 4);
				obj.CircleXZ(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				Pathfinding.Util.Draw obj = (Pathfinding.Util.Draw)ToLua.CheckObject<Pathfinding.Util.Draw>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Color arg2 = ToLua.ToColor(L, 4);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
				obj.CircleXZ(arg0, arg1, arg2, arg3);
				return 0;
			}
			else if (count == 6)
			{
				Pathfinding.Util.Draw obj = (Pathfinding.Util.Draw)ToLua.CheckObject<Pathfinding.Util.Draw>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Color arg2 = ToLua.ToColor(L, 4);
				float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
				float arg4 = (float)LuaDLL.luaL_checknumber(L, 6);
				obj.CircleXZ(arg0, arg1, arg2, arg3, arg4);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.Util.Draw.CircleXZ");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Cylinder(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			Pathfinding.Util.Draw obj = (Pathfinding.Util.Draw)ToLua.CheckObject<Pathfinding.Util.Draw>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
			UnityEngine.Color arg4 = ToLua.ToColor(L, 6);
			obj.Cylinder(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CrossXZ(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				Pathfinding.Util.Draw obj = (Pathfinding.Util.Draw)ToLua.CheckObject<Pathfinding.Util.Draw>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Color arg1 = ToLua.ToColor(L, 3);
				obj.CrossXZ(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				Pathfinding.Util.Draw obj = (Pathfinding.Util.Draw)ToLua.CheckObject<Pathfinding.Util.Draw>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Color arg1 = ToLua.ToColor(L, 3);
				float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
				obj.CrossXZ(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.Util.Draw.CrossXZ");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Bezier(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Pathfinding.Util.Draw obj = (Pathfinding.Util.Draw)ToLua.CheckObject<Pathfinding.Util.Draw>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 arg1 = ToLua.ToVector3(L, 3);
			UnityEngine.Color arg2 = ToLua.ToColor(L, 4);
			obj.Bezier(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Debug(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, Pathfinding.Util.Draw.Debug);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Gizmos(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, Pathfinding.Util.Draw.Gizmos);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
