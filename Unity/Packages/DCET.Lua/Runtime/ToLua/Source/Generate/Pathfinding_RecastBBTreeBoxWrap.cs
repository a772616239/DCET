﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_RecastBBTreeBoxWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.RecastBBTreeBox), typeof(System.Object));
		L.RegFunction("Contains", Contains);
		L.RegFunction("New", _CreatePathfinding_RecastBBTreeBox);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("rect", get_rect, set_rect);
		L.RegVar("mesh", get_mesh, set_mesh);
		L.RegVar("c1", get_c1, set_c1);
		L.RegVar("c2", get_c2, set_c2);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathfinding_RecastBBTreeBox(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				Pathfinding.RecastMeshObj arg0 = (Pathfinding.RecastMeshObj)ToLua.CheckObject<Pathfinding.RecastMeshObj>(L, 1);
				Pathfinding.RecastBBTreeBox obj = new Pathfinding.RecastBBTreeBox(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Pathfinding.RecastBBTreeBox.New");
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
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)ToLua.CheckObject<Pathfinding.RecastBBTreeBox>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			bool o = obj.Contains(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)o;
			UnityEngine.Rect ret = obj.rect;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_mesh(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)o;
			Pathfinding.RecastMeshObj ret = obj.mesh;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mesh on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_c1(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)o;
			Pathfinding.RecastBBTreeBox ret = obj.c1;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index c1 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_c2(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)o;
			Pathfinding.RecastBBTreeBox ret = obj.c2;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index c2 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_rect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)o;
			UnityEngine.Rect arg0 = StackTraits<UnityEngine.Rect>.Check(L, 2);
			obj.rect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rect on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_mesh(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)o;
			Pathfinding.RecastMeshObj arg0 = (Pathfinding.RecastMeshObj)ToLua.CheckObject<Pathfinding.RecastMeshObj>(L, 2);
			obj.mesh = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index mesh on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_c1(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)o;
			Pathfinding.RecastBBTreeBox arg0 = (Pathfinding.RecastBBTreeBox)ToLua.CheckObject<Pathfinding.RecastBBTreeBox>(L, 2);
			obj.c1 = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index c1 on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_c2(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RecastBBTreeBox obj = (Pathfinding.RecastBBTreeBox)o;
			Pathfinding.RecastBBTreeBox arg0 = (Pathfinding.RecastBBTreeBox)ToLua.CheckObject<Pathfinding.RecastBBTreeBox>(L, 2);
			obj.c2 = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index c2 on a nil value");
		}
	}
}

