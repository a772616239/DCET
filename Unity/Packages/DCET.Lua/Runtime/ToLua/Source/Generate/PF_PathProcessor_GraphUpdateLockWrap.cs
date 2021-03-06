﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_PathProcessor_GraphUpdateLockWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.PathProcessor.GraphUpdateLock), null);
		L.RegFunction("Release", Release);
		L.RegFunction("New", _CreatePF_PathProcessor_GraphUpdateLock);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Held", get_Held, null);
		L.RegFunction("getHeld", get_Held);
		L.RegFunction("default", __default__);
		L.RegFunction("__clone__", __clone__);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePF_PathProcessor_GraphUpdateLock(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				PF.PathProcessor arg0 = (PF.PathProcessor)ToLua.CheckObject<PF.PathProcessor>(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				PF.PathProcessor.GraphUpdateLock obj = new PF.PathProcessor.GraphUpdateLock(arg0, arg1);
				ToLua.PushValue(L, obj);
				return 1;
			}
			else if (count == 0)
			{
				PF.PathProcessor.GraphUpdateLock obj = new PF.PathProcessor.GraphUpdateLock();
				ToLua.PushValue(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PF.PathProcessor.GraphUpdateLock.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Release(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PF.PathProcessor.GraphUpdateLock obj = (PF.PathProcessor.GraphUpdateLock)ToLua.CheckObject(L, 1, typeof(PF.PathProcessor.GraphUpdateLock));
			obj.Release();
			ToLua.SetBack(L, 1, obj);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Held(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.PathProcessor.GraphUpdateLock obj = (PF.PathProcessor.GraphUpdateLock)o;
			bool ret = obj.Held;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Held on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int __default__(IntPtr L)
	{
		try
		{
			var o = new PF.PathProcessor.GraphUpdateLock();
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
			var obj = (PF.PathProcessor.GraphUpdateLock)ToLua.CheckObject(L, 1, typeof(PF.PathProcessor.GraphUpdateLock));
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

