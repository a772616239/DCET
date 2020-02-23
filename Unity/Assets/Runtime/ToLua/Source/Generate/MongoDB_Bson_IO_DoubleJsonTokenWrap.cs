﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_IO_DoubleJsonTokenWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.IO.DoubleJsonToken), typeof(MongoDB.Bson.IO.JsonToken));
		L.RegFunction("New", _CreateMongoDB_Bson_IO_DoubleJsonToken);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("DoubleValue", get_DoubleValue, null);
		L.RegFunction("getDoubleValue", get_DoubleValue);
		L.RegVar("Int32Value", get_Int32Value, null);
		L.RegFunction("getInt32Value", get_Int32Value);
		L.RegVar("Int64Value", get_Int64Value, null);
		L.RegFunction("getInt64Value", get_Int64Value);
		L.RegVar("IsNumber", get_IsNumber, null);
		L.RegFunction("getIsNumber", get_IsNumber);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_IO_DoubleJsonToken(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				double arg1 = (double)LuaDLL.luaL_checknumber(L, 2);
				MongoDB.Bson.IO.DoubleJsonToken obj = new MongoDB.Bson.IO.DoubleJsonToken(arg0, arg1);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.IO.DoubleJsonToken.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DoubleValue(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.DoubleJsonToken obj = (MongoDB.Bson.IO.DoubleJsonToken)o;
			double ret = obj.DoubleValue;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DoubleValue on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Int32Value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.DoubleJsonToken obj = (MongoDB.Bson.IO.DoubleJsonToken)o;
			int ret = obj.Int32Value;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Int32Value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Int64Value(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.DoubleJsonToken obj = (MongoDB.Bson.IO.DoubleJsonToken)o;
			long ret = obj.Int64Value;
			LuaDLL.tolua_pushint64(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Int64Value on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNumber(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.IO.DoubleJsonToken obj = (MongoDB.Bson.IO.DoubleJsonToken)o;
			bool ret = obj.IsNumber;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IsNumber on a nil value");
		}
	}
}
