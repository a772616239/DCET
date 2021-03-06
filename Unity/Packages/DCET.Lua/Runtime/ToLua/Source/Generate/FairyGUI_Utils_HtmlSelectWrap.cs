﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_Utils_HtmlSelectWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.Utils.HtmlSelect), typeof(System.Object));
		L.RegFunction("Create", Create);
		L.RegFunction("SetPosition", SetPosition);
		L.RegFunction("Add", Add);
		L.RegFunction("Remove", Remove);
		L.RegFunction("Release", Release);
		L.RegFunction("Dispose", Dispose);
		L.RegFunction("New", _CreateFairyGUI_Utils_HtmlSelect);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("CHANGED_EVENT", get_CHANGED_EVENT, null);
		L.RegVar("resource", get_resource, set_resource);
		L.RegVar("comboBox", get_comboBox, null);
		L.RegFunction("getcomboBox", get_comboBox);
		L.RegVar("displayObject", get_displayObject, null);
		L.RegFunction("getdisplayObject", get_displayObject);
		L.RegVar("element", get_element, null);
		L.RegFunction("getelement", get_element);
		L.RegVar("width", get_width, null);
		L.RegFunction("getwidth", get_width);
		L.RegVar("height", get_height, null);
		L.RegFunction("getheight", get_height);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_Utils_HtmlSelect(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.Utils.HtmlSelect obj = new FairyGUI.Utils.HtmlSelect();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.Utils.HtmlSelect.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Create(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)ToLua.CheckObject<FairyGUI.Utils.HtmlSelect>(L, 1);
			FairyGUI.RichTextField arg0 = (FairyGUI.RichTextField)ToLua.CheckObject<FairyGUI.RichTextField>(L, 2);
			FairyGUI.Utils.HtmlElement arg1 = (FairyGUI.Utils.HtmlElement)ToLua.CheckObject<FairyGUI.Utils.HtmlElement>(L, 3);
			obj.Create(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)ToLua.CheckObject<FairyGUI.Utils.HtmlSelect>(L, 1);
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.SetPosition(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Add(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)ToLua.CheckObject<FairyGUI.Utils.HtmlSelect>(L, 1);
			obj.Add();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Remove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)ToLua.CheckObject<FairyGUI.Utils.HtmlSelect>(L, 1);
			obj.Remove();
			return 0;
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
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)ToLua.CheckObject<FairyGUI.Utils.HtmlSelect>(L, 1);
			obj.Release();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Dispose(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)ToLua.CheckObject<FairyGUI.Utils.HtmlSelect>(L, 1);
			obj.Dispose();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CHANGED_EVENT(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, FairyGUI.Utils.HtmlSelect.CHANGED_EVENT);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_resource(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushstring(L, FairyGUI.Utils.HtmlSelect.resource);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_comboBox(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)o;
			FairyGUI.GComboBox ret = obj.comboBox;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index comboBox on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_displayObject(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)o;
			FairyGUI.DisplayObject ret = obj.displayObject;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index displayObject on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_element(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)o;
			FairyGUI.Utils.HtmlElement ret = obj.element;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index element on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_width(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)o;
			float ret = obj.width;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index width on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FairyGUI.Utils.HtmlSelect obj = (FairyGUI.Utils.HtmlSelect)o;
			float ret = obj.height;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_resource(IntPtr L)
	{
		try
		{
			string arg0 = ToLua.CheckString(L, 2);
			FairyGUI.Utils.HtmlSelect.resource = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

