﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Attributes_BsonIgnoreExtraElementsAttributeWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute), typeof(System.Attribute));
		L.RegFunction("Apply", Apply);
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Attributes_BsonIgnoreExtraElementsAttribute);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("IgnoreExtraElements", get_IgnoreExtraElements, null);
		L.RegFunction("getIgnoreExtraElements", get_IgnoreExtraElements);
		L.RegVar("Inherited", get_Inherited, set_Inherited);
		L.RegFunction("getInherited", get_Inherited);
		L.RegFunction("setInherited", set_Inherited);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Attributes_BsonIgnoreExtraElementsAttribute(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute obj = new MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute obj = new MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Apply(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute obj = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute)ToLua.CheckObject<MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute>(L, 1);
			MongoDB.Bson.Serialization.BsonClassMap arg0 = (MongoDB.Bson.Serialization.BsonClassMap)ToLua.CheckObject<MongoDB.Bson.Serialization.BsonClassMap>(L, 2);
			obj.Apply(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IgnoreExtraElements(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute obj = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute)o;
			bool ret = obj.IgnoreExtraElements;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index IgnoreExtraElements on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Inherited(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute obj = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute)o;
			bool ret = obj.Inherited;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Inherited on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Inherited(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute obj = (MongoDB.Bson.Serialization.Attributes.BsonIgnoreExtraElementsAttribute)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Inherited = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Inherited on a nil value");
		}
	}
}

