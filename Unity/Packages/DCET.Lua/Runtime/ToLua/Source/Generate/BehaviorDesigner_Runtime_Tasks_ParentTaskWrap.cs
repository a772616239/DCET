﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class BehaviorDesigner_Runtime_Tasks_ParentTaskWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(BehaviorDesigner.Runtime.Tasks.ParentTask), typeof(BehaviorDesigner.Runtime.Tasks.Task));
		L.RegFunction("MaxChildren", MaxChildren);
		L.RegFunction("CanRunParallelChildren", CanRunParallelChildren);
		L.RegFunction("CurrentChildIndex", CurrentChildIndex);
		L.RegFunction("CanExecute", CanExecute);
		L.RegFunction("Decorate", Decorate);
		L.RegFunction("CanReevaluate", CanReevaluate);
		L.RegFunction("OnReevaluationStarted", OnReevaluationStarted);
		L.RegFunction("OnReevaluationEnded", OnReevaluationEnded);
		L.RegFunction("OnChildExecuted", OnChildExecuted);
		L.RegFunction("OnChildStarted", OnChildStarted);
		L.RegFunction("OverrideStatus", OverrideStatus);
		L.RegFunction("OnConditionalAbort", OnConditionalAbort);
		L.RegFunction("GetUtility", GetUtility);
		L.RegFunction("OnDrawGizmos", OnDrawGizmos);
		L.RegFunction("AddChild", AddChild);
		L.RegFunction("ReplaceAddChild", ReplaceAddChild);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Children", get_Children, null);
		L.RegFunction("getChildren", get_Children);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MaxChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			int o = obj.MaxChildren();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanRunParallelChildren(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			bool o = obj.CanRunParallelChildren();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CurrentChildIndex(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			int o = obj.CurrentChildIndex();
			LuaDLL.lua_pushinteger(L, o);
			return 1;
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
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
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
	static int Decorate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
			BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.Decorate(arg0);
			LuaDLL.lua_pushinteger(L, (int)o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CanReevaluate(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			bool o = obj.CanReevaluate();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnReevaluationStarted(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			bool o = obj.OnReevaluationStarted();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnReevaluationEnded(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
			obj.OnReevaluationEnded(arg0);
			return 0;
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
				BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
				obj.OnChildExecuted(arg0);
				return 0;
			}
			else if (count == 3)
			{
				BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg1 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 3);
				obj.OnChildExecuted(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BehaviorDesigner.Runtime.Tasks.ParentTask.OnChildExecuted");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnChildStarted(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
				obj.OnChildStarted();
				return 0;
			}
			else if (count == 2)
			{
				BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.OnChildStarted(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BehaviorDesigner.Runtime.Tasks.ParentTask.OnChildStarted");
			}
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
				BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.OverrideStatus();
				LuaDLL.lua_pushinteger(L, (int)o);
				return 1;
			}
			else if (count == 2)
			{
				BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
				BehaviorDesigner.Runtime.Tasks.TaskStatus arg0 = (BehaviorDesigner.Runtime.Tasks.TaskStatus)LuaDLL.luaL_checknumber(L, 2);
				BehaviorDesigner.Runtime.Tasks.TaskStatus o = obj.OverrideStatus(arg0);
				LuaDLL.lua_pushinteger(L, (int)o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BehaviorDesigner.Runtime.Tasks.ParentTask.OverrideStatus");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnConditionalAbort(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
				obj.OnConditionalAbort();
				return 0;
			}
			else if (count == 2)
			{
				BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.OnConditionalAbort(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: BehaviorDesigner.Runtime.Tasks.ParentTask.OnConditionalAbort");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetUtility(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			float o = obj.GetUtility();
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrawGizmos(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			obj.OnDrawGizmos();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			BehaviorDesigner.Runtime.Tasks.Task arg0 = (BehaviorDesigner.Runtime.Tasks.Task)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Task>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.AddChild(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ReplaceAddChild(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.ParentTask>(L, 1);
			BehaviorDesigner.Runtime.Tasks.Task arg0 = (BehaviorDesigner.Runtime.Tasks.Task)ToLua.CheckObject<BehaviorDesigner.Runtime.Tasks.Task>(L, 2);
			int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
			obj.ReplaceAddChild(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Children(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			BehaviorDesigner.Runtime.Tasks.ParentTask obj = (BehaviorDesigner.Runtime.Tasks.ParentTask)o;
			System.Collections.Generic.List<BehaviorDesigner.Runtime.Tasks.Task> ret = obj.Children;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Children on a nil value");
		}
	}
}

