﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class MongoDB_Bson_Serialization_Serializers_VersionSerializerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(MongoDB.Bson.Serialization.Serializers.VersionSerializer), typeof(MongoDB.Bson.Serialization.Serializers.SealedClassSerializerBase<System.Version>));
		L.RegFunction("WithRepresentation", WithRepresentation);
		L.RegFunction("New", _CreateMongoDB_Bson_Serialization_Serializers_VersionSerializer);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("Representation", get_Representation, null);
		L.RegFunction("getRepresentation", get_Representation);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateMongoDB_Bson_Serialization_Serializers_VersionSerializer(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				MongoDB.Bson.Serialization.Serializers.VersionSerializer obj = new MongoDB.Bson.Serialization.Serializers.VersionSerializer();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 1)
			{
				MongoDB.Bson.BsonType arg0 = (MongoDB.Bson.BsonType)LuaDLL.luaL_checknumber(L, 1);
				MongoDB.Bson.Serialization.Serializers.VersionSerializer obj = new MongoDB.Bson.Serialization.Serializers.VersionSerializer(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: MongoDB.Bson.Serialization.Serializers.VersionSerializer.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int WithRepresentation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			MongoDB.Bson.Serialization.Serializers.VersionSerializer obj = (MongoDB.Bson.Serialization.Serializers.VersionSerializer)ToLua.CheckObject<MongoDB.Bson.Serialization.Serializers.VersionSerializer>(L, 1);
			MongoDB.Bson.BsonType arg0 = (MongoDB.Bson.BsonType)LuaDLL.luaL_checknumber(L, 2);
			MongoDB.Bson.Serialization.Serializers.VersionSerializer o = obj.WithRepresentation(arg0);
			ToLua.PushObject(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Representation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			MongoDB.Bson.Serialization.Serializers.VersionSerializer obj = (MongoDB.Bson.Serialization.Serializers.VersionSerializer)o;
			MongoDB.Bson.BsonType ret = obj.Representation;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Representation on a nil value");
		}
	}
}
