﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_RandomPathWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.RandomPath), typeof(PF.ABPath));
		L.RegFunction("Construct", Construct);
		L.RegFunction("New", _CreatePF_RandomPath);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("searchLength", get_searchLength, set_searchLength);
		L.RegVar("spread", get_spread, set_spread);
		L.RegVar("aimStrength", get_aimStrength, set_aimStrength);
		L.RegVar("aim", get_aim, set_aim);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePF_RandomPath(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				PF.RandomPath obj = new PF.RandomPath();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PF.RandomPath.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Construct(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				PF.RandomPath o = PF.RandomPath.Construct(arg0, arg1);
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 3)
			{
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				PF.OnPathDelegate arg2 = (PF.OnPathDelegate)ToLua.CheckDelegate<PF.OnPathDelegate>(L, 3);
				PF.RandomPath o = PF.RandomPath.Construct(arg0, arg1, arg2);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.RandomPath.Construct");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_searchLength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RandomPath obj = (PF.RandomPath)o;
			int ret = obj.searchLength;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index searchLength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spread(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RandomPath obj = (PF.RandomPath)o;
			int ret = obj.spread;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spread on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_aimStrength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RandomPath obj = (PF.RandomPath)o;
			float ret = obj.aimStrength;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index aimStrength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_aim(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RandomPath obj = (PF.RandomPath)o;
			UnityEngine.Vector3 ret = obj.aim;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index aim on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_searchLength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RandomPath obj = (PF.RandomPath)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.searchLength = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index searchLength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spread(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RandomPath obj = (PF.RandomPath)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.spread = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spread on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_aimStrength(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RandomPath obj = (PF.RandomPath)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.aimStrength = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index aimStrength on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_aim(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.RandomPath obj = (PF.RandomPath)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.aim = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index aim on a nil value");
		}
	}
}

