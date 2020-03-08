﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_RVO_IAgentWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.RVO.IAgent), null);
		L.RegFunction("SetTarget", SetTarget);
		L.RegFunction("SetCollisionNormal", SetCollisionNormal);
		L.RegFunction("ForceSetVelocity", ForceSetVelocity);
		L.RegVar("Position", get_Position, set_Position);
		L.RegFunction("getPosition", get_Position);
		L.RegFunction("setPosition", set_Position);
		L.RegVar("ElevationCoordinate", get_ElevationCoordinate, set_ElevationCoordinate);
		L.RegFunction("getElevationCoordinate", get_ElevationCoordinate);
		L.RegFunction("setElevationCoordinate", set_ElevationCoordinate);
		L.RegVar("CalculatedTargetPoint", get_CalculatedTargetPoint, null);
		L.RegFunction("getCalculatedTargetPoint", get_CalculatedTargetPoint);
		L.RegVar("CalculatedSpeed", get_CalculatedSpeed, null);
		L.RegFunction("getCalculatedSpeed", get_CalculatedSpeed);
		L.RegVar("Locked", get_Locked, set_Locked);
		L.RegFunction("getLocked", get_Locked);
		L.RegFunction("setLocked", set_Locked);
		L.RegVar("Radius", get_Radius, set_Radius);
		L.RegFunction("getRadius", get_Radius);
		L.RegFunction("setRadius", set_Radius);
		L.RegVar("Height", get_Height, set_Height);
		L.RegFunction("getHeight", get_Height);
		L.RegFunction("setHeight", set_Height);
		L.RegVar("AgentTimeHorizon", get_AgentTimeHorizon, set_AgentTimeHorizon);
		L.RegFunction("getAgentTimeHorizon", get_AgentTimeHorizon);
		L.RegFunction("setAgentTimeHorizon", set_AgentTimeHorizon);
		L.RegVar("ObstacleTimeHorizon", get_ObstacleTimeHorizon, set_ObstacleTimeHorizon);
		L.RegFunction("getObstacleTimeHorizon", get_ObstacleTimeHorizon);
		L.RegFunction("setObstacleTimeHorizon", set_ObstacleTimeHorizon);
		L.RegVar("MaxNeighbours", get_MaxNeighbours, set_MaxNeighbours);
		L.RegFunction("getMaxNeighbours", get_MaxNeighbours);
		L.RegFunction("setMaxNeighbours", set_MaxNeighbours);
		L.RegVar("NeighbourCount", get_NeighbourCount, null);
		L.RegFunction("getNeighbourCount", get_NeighbourCount);
		L.RegVar("Layer", get_Layer, set_Layer);
		L.RegFunction("getLayer", get_Layer);
		L.RegFunction("setLayer", set_Layer);
		L.RegVar("CollidesWith", get_CollidesWith, set_CollidesWith);
		L.RegFunction("getCollidesWith", get_CollidesWith);
		L.RegFunction("setCollidesWith", set_CollidesWith);
		L.RegVar("DebugDraw", get_DebugDraw, set_DebugDraw);
		L.RegFunction("getDebugDraw", get_DebugDraw);
		L.RegFunction("setDebugDraw", set_DebugDraw);
		L.RegVar("Priority", get_Priority, set_Priority);
		L.RegFunction("getPriority", get_Priority);
		L.RegFunction("setPriority", set_Priority);
		L.RegVar("PreCalculationCallback", null, set_PreCalculationCallback);
		L.RegFunction("setPreCalculationCallback", set_PreCalculationCallback);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTarget(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)ToLua.CheckObject<Pathfinding.RVO.IAgent>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			obj.SetTarget(arg0, arg1, arg2);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCollisionNormal(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)ToLua.CheckObject<Pathfinding.RVO.IAgent>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.SetCollisionNormal(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ForceSetVelocity(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)ToLua.CheckObject<Pathfinding.RVO.IAgent>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.ForceSetVelocity(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			UnityEngine.Vector2 ret = obj.Position;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ElevationCoordinate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float ret = obj.ElevationCoordinate;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ElevationCoordinate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CalculatedTargetPoint(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			UnityEngine.Vector2 ret = obj.CalculatedTargetPoint;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CalculatedTargetPoint on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CalculatedSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float ret = obj.CalculatedSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CalculatedSpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Locked(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			bool ret = obj.Locked;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Locked on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float ret = obj.Radius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float ret = obj.Height;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AgentTimeHorizon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float ret = obj.AgentTimeHorizon;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AgentTimeHorizon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ObstacleTimeHorizon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float ret = obj.ObstacleTimeHorizon;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ObstacleTimeHorizon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MaxNeighbours(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			int ret = obj.MaxNeighbours;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MaxNeighbours on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NeighbourCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			int ret = obj.NeighbourCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index NeighbourCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Layer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			Pathfinding.RVO.RVOLayer ret = obj.Layer;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Layer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CollidesWith(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			Pathfinding.RVO.RVOLayer ret = obj.CollidesWith;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CollidesWith on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_DebugDraw(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			bool ret = obj.DebugDraw;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DebugDraw on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Priority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float ret = obj.Priority;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Priority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			obj.Position = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ElevationCoordinate(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.ElevationCoordinate = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ElevationCoordinate on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Locked(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Locked = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Locked on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Radius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Height = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AgentTimeHorizon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.AgentTimeHorizon = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index AgentTimeHorizon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ObstacleTimeHorizon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.ObstacleTimeHorizon = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ObstacleTimeHorizon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_MaxNeighbours(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.MaxNeighbours = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index MaxNeighbours on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Layer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			Pathfinding.RVO.RVOLayer arg0 = (Pathfinding.RVO.RVOLayer)LuaDLL.luaL_checknumber(L, 2);
			obj.Layer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Layer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CollidesWith(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			Pathfinding.RVO.RVOLayer arg0 = (Pathfinding.RVO.RVOLayer)LuaDLL.luaL_checknumber(L, 2);
			obj.CollidesWith = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index CollidesWith on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_DebugDraw(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.DebugDraw = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index DebugDraw on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Priority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Priority = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index Priority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_PreCalculationCallback(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.IAgent obj = (Pathfinding.RVO.IAgent)o;
			System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 2);
			obj.PreCalculationCallback = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index PreCalculationCallback on a nil value");
		}
	}
}
