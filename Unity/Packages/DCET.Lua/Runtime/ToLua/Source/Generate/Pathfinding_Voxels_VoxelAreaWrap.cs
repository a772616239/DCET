﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_Voxels_VoxelAreaWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.Voxels.VoxelArea), typeof(System.Object));
		L.RegFunction("Reset", Reset);
		L.RegFunction("GetSpanCountAll", GetSpanCountAll);
		L.RegFunction("GetSpanCount", GetSpanCount);
		L.RegFunction("AddLinkedSpan", AddLinkedSpan);
		L.RegFunction("New", _CreatePathfinding_Voxels_VoxelArea);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegConstant("MaxHeight", 65536);
		L.RegConstant("MaxHeightInt", 65536);
		L.RegConstant("InvalidSpanValue", 4294967295);
		L.RegConstant("AvgSpanLayerCountEstimate", 8);
		L.RegVar("width", get_width, null);
		L.RegVar("depth", get_depth, null);
		L.RegVar("compactSpans", get_compactSpans, set_compactSpans);
		L.RegVar("compactCells", get_compactCells, set_compactCells);
		L.RegVar("compactSpanCount", get_compactSpanCount, set_compactSpanCount);
		L.RegVar("tmpUShortArr", get_tmpUShortArr, set_tmpUShortArr);
		L.RegVar("areaTypes", get_areaTypes, set_areaTypes);
		L.RegVar("dist", get_dist, set_dist);
		L.RegVar("maxDistance", get_maxDistance, set_maxDistance);
		L.RegVar("maxRegions", get_maxRegions, set_maxRegions);
		L.RegVar("DirectionX", get_DirectionX, set_DirectionX);
		L.RegVar("DirectionZ", get_DirectionZ, set_DirectionZ);
		L.RegVar("VectorDirection", get_VectorDirection, set_VectorDirection);
		L.RegVar("linkedSpans", get_linkedSpans, set_linkedSpans);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePathfinding_Voxels_VoxelArea(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				Pathfinding.Voxels.VoxelArea obj = new Pathfinding.Voxels.VoxelArea(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: Pathfinding.Voxels.VoxelArea.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Reset(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)ToLua.CheckObject<Pathfinding.Voxels.VoxelArea>(L, 1);
			obj.Reset();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSpanCountAll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)ToLua.CheckObject<Pathfinding.Voxels.VoxelArea>(L, 1);
			int o = obj.GetSpanCountAll();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetSpanCount(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)ToLua.CheckObject<Pathfinding.Voxels.VoxelArea>(L, 1);
			int o = obj.GetSpanCount();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddLinkedSpan(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 6);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)ToLua.CheckObject<Pathfinding.Voxels.VoxelArea>(L, 1);
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			uint arg1 = (uint)LuaDLL.luaL_checknumber(L, 3);
			uint arg2 = (uint)LuaDLL.luaL_checknumber(L, 4);
			int arg3 = (int)LuaDLL.luaL_checknumber(L, 5);
			int arg4 = (int)LuaDLL.luaL_checknumber(L, 6);
			obj.AddLinkedSpan(arg0, arg1, arg2, arg3, arg4);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int ret = obj.width;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index width on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_depth(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int ret = obj.depth;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index depth on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_compactSpans(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			Pathfinding.Voxels.CompactVoxelSpan[] ret = obj.compactSpans;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index compactSpans on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_compactCells(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			Pathfinding.Voxels.CompactVoxelCell[] ret = obj.compactCells;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index compactCells on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_compactSpanCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int ret = obj.compactSpanCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index compactSpanCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tmpUShortArr(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			ushort[] ret = obj.tmpUShortArr;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tmpUShortArr on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_areaTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int[] ret = obj.areaTypes;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index areaTypes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			ushort[] ret = obj.dist;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dist on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			ushort ret = obj.maxDistance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxRegions(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int ret = obj.maxRegions;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxRegions on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DirectionX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int[] ret = obj.DirectionX;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DirectionX on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DirectionZ(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int[] ret = obj.DirectionZ;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DirectionZ on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_VectorDirection(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			UnityEngine.Vector3[] ret = obj.VectorDirection;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index VectorDirection on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_linkedSpans(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			Pathfinding.Voxels.LinkedVoxelSpan[] ret = obj.linkedSpans;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index linkedSpans on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_compactSpans(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			Pathfinding.Voxels.CompactVoxelSpan[] arg0 = ToLua.CheckStructArray<Pathfinding.Voxels.CompactVoxelSpan>(L, 2);
			obj.compactSpans = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index compactSpans on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_compactCells(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			Pathfinding.Voxels.CompactVoxelCell[] arg0 = ToLua.CheckStructArray<Pathfinding.Voxels.CompactVoxelCell>(L, 2);
			obj.compactCells = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index compactCells on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_compactSpanCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.compactSpanCount = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index compactSpanCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tmpUShortArr(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			ushort[] arg0 = ToLua.CheckNumberArray<ushort>(L, 2);
			obj.tmpUShortArr = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tmpUShortArr on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_areaTypes(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			obj.areaTypes = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index areaTypes on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dist(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			ushort[] arg0 = ToLua.CheckNumberArray<ushort>(L, 2);
			obj.dist = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index dist on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			ushort arg0 = (ushort)LuaDLL.luaL_checknumber(L, 2);
			obj.maxDistance = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxDistance on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxRegions(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.maxRegions = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxRegions on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DirectionX(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			obj.DirectionX = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DirectionX on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DirectionZ(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			obj.DirectionZ = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DirectionZ on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_VectorDirection(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			UnityEngine.Vector3[] arg0 = ToLua.CheckStructArray<UnityEngine.Vector3>(L, 2);
			obj.VectorDirection = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index VectorDirection on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_linkedSpans(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.Voxels.VoxelArea obj = (Pathfinding.Voxels.VoxelArea)o;
			Pathfinding.Voxels.LinkedVoxelSpan[] arg0 = ToLua.CheckStructArray<Pathfinding.Voxels.LinkedVoxelSpan>(L, 2);
			obj.linkedSpans = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index linkedSpans on a nil value");
		}
	}
}

