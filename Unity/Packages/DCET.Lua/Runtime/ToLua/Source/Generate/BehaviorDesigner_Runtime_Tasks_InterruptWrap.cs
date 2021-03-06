﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BehaviorDesigner_Runtime_Tasks_InterruptWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BehaviorDesigner.Runtime.Tasks.Interrupt), typeof(BehaviorDesigner.Runtime.Tasks.Decorator));
		L.RegFunction("CanExecute", CanExecute);
		L.RegFunction("OnChildExecuted", OnChildExecuted);
		L.RegFunction("DoInterrupt", DoInterrupt);
		L.RegFunction("OverrideStatus", OverrideStatus);
		L.RegFunction("OnEnd", OnEnd);
		L.RegFunction("New", _CreateBehaviorDesigner_Runtime_Tasks_Interrupt);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateBehaviorDesigner_Runtime_Tasks_Interrupt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				BehaviorDesigner.Runtime.Tasks.Interrupt obj = new BehaviorDesigner.Runtime.Tasks.Interrupt();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: BehaviorDesigner.Runtime.Tasks.Interrupt.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanExecute(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.Interrupt obj = (BehaviorDesigner.Runtime.Tasks.Interrupt)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Interrupt>(L, 1);
			bool o = obj.CanExecute();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnChildExecuted(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				BehaviorDesigner.Runtime.Tasks.Interrupt obj = (BehaviorDesigner.Runtime.Tasks.Interrupt)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Interrupt>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
				obj.OnChildExecuted(arg0);
				return 0;
			}
			else if (count == 3)
			{
				BehaviorDesigner.Runtime.Tasks.Interrupt obj = (BehaviorDesigner.Runtime.Tasks.Interrupt)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Interrupt>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg1 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 3);
				obj.OnChildExecuted(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BehaviorDesigner.Runtime.Tasks.Interrupt.OnChildExecuted");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DoInterrupt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BehaviorDesigner.Runtime.Tasks.Interrupt obj = (BehaviorDesigner.Runtime.Tasks.Interrupt)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Interrupt>(L, 1);
			BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
			obj.DoInterrupt(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OverrideStatus(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				BehaviorDesigner.Runtime.Tasks.Interrupt obj = (BehaviorDesigner.Runtime.Tasks.Interrupt)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Interrupt>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.OverrideStatus();
				LuaDLL.lua_pushinteger(L, (int)o);
				return 1;
			}
			else if (count == 2)
			{
				BehaviorDesigner.Runtime.Tasks.Interrupt obj = (BehaviorDesigner.Runtime.Tasks.Interrupt)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Interrupt>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
				BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.OverrideStatus(arg0);
				LuaDLL.lua_pushinteger(L, (int)o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BehaviorDesigner.Runtime.Tasks.Interrupt.OverrideStatus");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEnd(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.Interrupt obj = (BehaviorDesigner.Runtime.Tasks.Interrupt)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Interrupt>(L, 1);
			obj.OnEnd();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

