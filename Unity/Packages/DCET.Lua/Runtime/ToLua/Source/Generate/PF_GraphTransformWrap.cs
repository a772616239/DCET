﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PF_GraphTransformWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PF.GraphTransform), typeof(System.Object));
		L.RegFunction("WorldUpAtGraphPosition", WorldUpAtGraphPosition);
		L.RegFunction("Transform", Transform);
		L.RegFunction("TransformVector", TransformVector);
		L.RegFunction("InverseTransform", InverseTransform);
		L.RegFunction("New", _CreatePF_GraphTransform);
		L.RegFunction("__mul", op_Multiply);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("identity", get_identity, null);
		L.RegVar("onlyTranslational", get_onlyTranslational, null);
		L.RegVar("translation", get_translation, null);
		L.RegVar("identityTransform", get_identityTransform, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreatePF_GraphTransform(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.Check(L, 1);
				PF.GraphTransform obj = new PF.GraphTransform(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: PF.GraphTransform.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WorldUpAtGraphPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.GraphTransform obj = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 o = obj.WorldUpAtGraphPosition(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Transform(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Vector3>(L, 2))
			{
				PF.GraphTransform obj = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.Transform(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<PF.Int3[]>(L, 2))
			{
				PF.GraphTransform obj = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 1);
				PF.Int3[] arg0 = ToLua.ToStructArray<PF.Int3>(L, 2);
				obj.Transform(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Vector3[]>(L, 2))
			{
				PF.GraphTransform obj = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 1);
				UnityEngine.Vector3[] arg0 = ToLua.ToStructArray<UnityEngine.Vector3>(L, 2);
				obj.Transform(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.GraphTransform.Transform");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TransformVector(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PF.GraphTransform obj = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			UnityEngine.Vector3 o = obj.TransformVector(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int InverseTransform(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Vector3>(L, 2))
			{
				PF.GraphTransform obj = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector3 o = obj.InverseTransform(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<PF.Int3>(L, 2))
			{
				PF.GraphTransform obj = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 1);
				PF.Int3 arg0 = StackTraits<PF.Int3>.To(L, 2);
				PF.Int3 o = obj.InverseTransform(arg0);
				ToLua.PushValue(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<PF.Int3[]>(L, 2))
			{
				PF.GraphTransform obj = (PF.GraphTransform)ToLua.CheckObject<PF.GraphTransform>(L, 1);
				PF.Int3[] arg0 = ToLua.ToStructArray<PF.Int3>(L, 2);
				obj.InverseTransform(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.GraphTransform.InverseTransform");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Multiply(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<PF.GraphTransform, UnityEngine.Matrix4x4>(L, 1))
			{
				PF.GraphTransform arg0 = (PF.GraphTransform)ToLua.ToObject(L, 1);
				UnityEngine.Matrix4x4 arg1 = StackTraits<UnityEngine.Matrix4x4>.To(L, 2);
				PF.GraphTransform o = arg0 * arg1;
				ToLua.PushObject(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.Matrix4x4, PF.GraphTransform>(L, 1))
			{
				UnityEngine.Matrix4x4 arg0 = StackTraits<UnityEngine.Matrix4x4>.To(L, 1);
				PF.GraphTransform arg1 = (PF.GraphTransform)ToLua.ToObject(L, 2);
				PF.GraphTransform o = arg0 * arg1;
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: PF.GraphTransform.op_Multiply");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_identity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.GraphTransform obj = (PF.GraphTransform)o;
			bool ret = obj.identity;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index identity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onlyTranslational(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.GraphTransform obj = (PF.GraphTransform)o;
			bool ret = obj.onlyTranslational;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onlyTranslational on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_translation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PF.GraphTransform obj = (PF.GraphTransform)o;
			UnityEngine.Vector3 ret = obj.translation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index translation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_identityTransform(IntPtr L)
	{
		try
		{
			ToLua.PushObject(L, PF.GraphTransform.identityTransform);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

