﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_Utils_XMLIteratorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.Utils.XMLIterator), typeof(System.Object));
		L.RegFunction("Begin", Begin);
		L.RegFunction("NextTag", NextTag);
		L.RegFunction("GetTagSource", GetTagSource);
		L.RegFunction("GetRawText", GetRawText);
		L.RegFunction("GetText", GetText);
		L.RegFunction("HasAttribute", HasAttribute);
		L.RegFunction("GetAttribute", GetAttribute);
		L.RegFunction("GetAttributeInt", GetAttributeInt);
		L.RegFunction("GetAttributeFloat", GetAttributeFloat);
		L.RegFunction("GetAttributeBool", GetAttributeBool);
		L.RegFunction("GetAttributes", GetAttributes);
		L.RegFunction("New", _CreateFairyGUI_Utils_XMLIterator);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("tagName", get_tagName, set_tagName);
		L.RegVar("tagType", get_tagType, set_tagType);
		L.RegVar("lastTagName", get_lastTagName, set_lastTagName);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_Utils_XMLIterator(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.Utils.XMLIterator obj = new FairyGUI.Utils.XMLIterator();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.Utils.XMLIterator.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Begin(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				FairyGUI.Utils.XMLIterator.Begin(arg0);
				return 0;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				FairyGUI.Utils.XMLIterator.Begin(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Utils.XMLIterator.Begin");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int NextTag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			bool o = FairyGUI.Utils.XMLIterator.NextTag();
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTagSource(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			string o = FairyGUI.Utils.XMLIterator.GetTagSource();
			LuaDLL.lua_pushstring(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRawText(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				string o = FairyGUI.Utils.XMLIterator.GetRawText();
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				string o = FairyGUI.Utils.XMLIterator.GetRawText(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Utils.XMLIterator.GetRawText");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetText(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				string o = FairyGUI.Utils.XMLIterator.GetText();
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				string o = FairyGUI.Utils.XMLIterator.GetText(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Utils.XMLIterator.GetText");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasAttribute(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			bool o = FairyGUI.Utils.XMLIterator.HasAttribute(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAttribute(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string o = FairyGUI.Utils.XMLIterator.GetAttribute(arg0);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				string arg1 = ToLua.CheckString(L, 2);
				string o = FairyGUI.Utils.XMLIterator.GetAttribute(arg0, arg1);
				LuaDLL.lua_pushstring(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Utils.XMLIterator.GetAttribute");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAttributeInt(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				int o = FairyGUI.Utils.XMLIterator.GetAttributeInt(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				int o = FairyGUI.Utils.XMLIterator.GetAttributeInt(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Utils.XMLIterator.GetAttributeInt");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAttributeFloat(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				float o = FairyGUI.Utils.XMLIterator.GetAttributeFloat(arg0);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 2);
				float o = FairyGUI.Utils.XMLIterator.GetAttributeFloat(arg0, arg1);
				LuaDLL.lua_pushnumber(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Utils.XMLIterator.GetAttributeFloat");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAttributeBool(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				string arg0 = ToLua.CheckString(L, 1);
				bool o = FairyGUI.Utils.XMLIterator.GetAttributeBool(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 2);
				bool o = FairyGUI.Utils.XMLIterator.GetAttributeBool(arg0, arg1);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Utils.XMLIterator.GetAttributeBool");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAttributes(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<System.Collections.Generic.Dictionary<string,string>>(L, 1))
			{
				System.Collections.Generic.Dictionary<string,string> arg0 = (System.Collections.Generic.Dictionary<string,string>)ToLua.ToObject(L, 1);
				System.Collections.Generic.Dictionary<string,string> o = FairyGUI.Utils.XMLIterator.GetAttributes(arg0);
				ToLua.PushSealed(L, o);
				return 1;
			}
			else if (count == 1 && TypeChecker.CheckTypes<System.Collections.Hashtable>(L, 1))
			{
				System.Collections.Hashtable arg0 = (System.Collections.Hashtable)ToLua.ToObject(L, 1);
				System.Collections.Hashtable o = FairyGUI.Utils.XMLIterator.GetAttributes(arg0);
				ToLua.PushObject(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FairyGUI.Utils.XMLIterator.GetAttributes");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tagName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, FairyGUI.Utils.XMLIterator.tagName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tagType(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, (int)FairyGUI.Utils.XMLIterator.tagType);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lastTagName(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, FairyGUI.Utils.XMLIterator.lastTagName);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tagName(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.Utils.XMLIterator.tagName = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tagType(IntPtr L)
	{
		try
		{
			FairyGUI.Utils.XMLTagType arg0 = (FairyGUI.Utils.XMLTagType)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.Utils.XMLIterator.tagType = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lastTagName(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.Utils.XMLIterator.lastTagName = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

