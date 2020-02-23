﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Serializers_StackSerializerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Serializers.StackSerializer), typeof(MongoDB.Bson.Serialization.Serializers.EnumerableSerializerBase<System.Collections.Stack>));
		L.RegFunction("WithItemSerializer", WithItemSerializer);
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Serializers_StackSerializer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Serializers_StackSerializer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Serializers.StackSerializer obj = new MongoDB.Bson.Serialization.Serializers.StackSerializer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<MongoDB.Bson.Serialization.IBsonSerializer>(L, 1))
			{
				MongoDB.Bson.Serialization.IBsonSerializer arg0 = (MongoDB.Bson.Serialization.IBsonSerializer)ToLua.ToObject(L, 1);
				MongoDB.Bson.Serialization.Serializers.StackSerializer obj = new MongoDB.Bson.Serialization.Serializers.StackSerializer(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<MongoDB.Bson.Serialization.IBsonSerializerRegistry>(L, 1))
			{
				MongoDB.Bson.Serialization.IBsonSerializerRegistry arg0 = (MongoDB.Bson.Serialization.IBsonSerializerRegistry)ToLua.ToObject(L, 1);
				MongoDB.Bson.Serialization.Serializers.StackSerializer obj = new MongoDB.Bson.Serialization.Serializers.StackSerializer(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Serializers.StackSerializer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WithItemSerializer(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.Serialization.Serializers.StackSerializer obj = (MongoDB.Bson.Serialization.Serializers.StackSerializer)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.StackSerializer>(L, 1);
			MongoDB.Bson.Serialization.IBsonSerializer arg0 = (MongoDB.Bson.Serialization.IBsonSerializer)ToLua.CheckObject<MongoDB.Bson.Serialization.IBsonSerializer>(L, 2);
			MongoDB.Bson.Serialization.Serializers.StackSerializer o = obj.WithItemSerializer(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
