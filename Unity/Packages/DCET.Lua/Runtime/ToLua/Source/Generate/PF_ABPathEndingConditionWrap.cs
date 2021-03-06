﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_ABPathEndingConditionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.ABPathEndingCondition), typeof(PF.PathEndingCondition));
		L.RegFunction("TargetFound", TargetFound);
		L.RegFunction("New", _CreatePF_ABPathEndingCondition);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePF_ABPathEndingCondition(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				PF.ABPath arg0 = (PF.ABPath)ToLua.CheckObject<PF.ABPath>(L, 1);
				PF.ABPathEndingCondition obj = new PF.ABPathEndingCondition(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PF.ABPathEndingCondition.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TargetFound(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.ABPathEndingCondition obj = (PF.ABPathEndingCondition)ToLua.CheckObject<PF.ABPathEndingCondition>(L, 1);
			PF.PathNode arg0 = (PF.PathNode)ToLua.CheckObject<PF.PathNode>(L, 2);
			bool o = obj.TargetFound(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

