﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FairyGUI_HitTestContextWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FairyGUI.HitTestContext), typeof(System.Object));
		L.RegFunction("GetRaycastHitFromCache", GetRaycastHitFromCache);
		L.RegFunction("CacheRaycastHit", CacheRaycastHit);
		L.RegFunction("ClearRaycastHitCache", ClearRaycastHitCache);
		L.RegFunction("New", _CreateFairyGUI_HitTestContext);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("screenPoint", get_screenPoint, set_screenPoint);
		L.RegVar("worldPoint", get_worldPoint, set_worldPoint);
		L.RegVar("direction", get_direction, set_direction);
		L.RegVar("forTouch", get_forTouch, set_forTouch);
		L.RegVar("camera", get_camera, set_camera);
		L.RegVar("layerMask", get_layerMask, set_layerMask);
		L.RegVar("maxDistance", get_maxDistance, set_maxDistance);
		L.RegVar("cachedMainCamera", get_cachedMainCamera, set_cachedMainCamera);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFairyGUI_HitTestContext(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FairyGUI.HitTestContext obj = new FairyGUI.HitTestContext();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FairyGUI.HitTestContext.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRaycastHitFromCache(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 1, typeof(UnityEngine.Camera));
			UnityEngine.RaycastHit arg1;
			bool o = FairyGUI.HitTestContext.GetRaycastHitFromCache(arg0, out arg1);
			LuaDLL.lua_pushboolean(L, o);
			ToLua.Push(L, arg1);
			return 2;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CacheRaycastHit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 1, typeof(UnityEngine.Camera));
			UnityEngine.RaycastHit arg1 = StackTraits<UnityEngine.RaycastHit>.Check(L, 2);
			FairyGUI.HitTestContext.CacheRaycastHit(arg0, ref arg1);
			ToLua.Push(L, arg1);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ClearRaycastHitCache(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			FairyGUI.HitTestContext.ClearRaycastHitCache();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_screenPoint(IntPtr L)
	{
		try
		{
			ToLua.Push(L, FairyGUI.HitTestContext.screenPoint);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_worldPoint(IntPtr L)
	{
		try
		{
			ToLua.Push(L, FairyGUI.HitTestContext.worldPoint);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_direction(IntPtr L)
	{
		try
		{
			ToLua.Push(L, FairyGUI.HitTestContext.direction);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forTouch(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, FairyGUI.HitTestContext.forTouch);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_camera(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, FairyGUI.HitTestContext.camera);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layerMask(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushinteger(L, FairyGUI.HitTestContext.layerMask);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxDistance(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushnumber(L, FairyGUI.HitTestContext.maxDistance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cachedMainCamera(IntPtr L)
	{
		try
		{
			ToLua.PushSealed(L, FairyGUI.HitTestContext.cachedMainCamera);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_screenPoint(IntPtr L)
	{
		try
		{
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			FairyGUI.HitTestContext.screenPoint = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_worldPoint(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			FairyGUI.HitTestContext.worldPoint = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_direction(IntPtr L)
	{
		try
		{
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			FairyGUI.HitTestContext.direction = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_forTouch(IntPtr L)
	{
		try
		{
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			FairyGUI.HitTestContext.forTouch = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_camera(IntPtr L)
	{
		try
		{
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 2, typeof(UnityEngine.Camera));
			FairyGUI.HitTestContext.camera = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_layerMask(IntPtr L)
	{
		try
		{
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.HitTestContext.layerMask = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxDistance(IntPtr L)
	{
		try
		{
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			FairyGUI.HitTestContext.maxDistance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cachedMainCamera(IntPtr L)
	{
		try
		{
			UnityEngine.Camera arg0 = (UnityEngine.Camera)ToLua.CheckObject(L, 2, typeof(UnityEngine.Camera));
			FairyGUI.HitTestContext.cachedMainCamera = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
