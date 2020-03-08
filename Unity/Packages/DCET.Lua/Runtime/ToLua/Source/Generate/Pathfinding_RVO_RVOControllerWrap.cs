﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class Pathfinding_RVO_RVOControllerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(Pathfinding.RVO.RVOController), typeof(Pathfinding.VersionedMonoBehaviour));
		L.RegFunction("CalculateMovementDelta", CalculateMovementDelta);
		L.RegFunction("SetCollisionNormal", SetCollisionNormal);
		L.RegFunction("To2D", To2D);
		L.RegFunction("To3D", To3D);
		L.RegFunction("SetTarget", SetTarget);
		L.RegFunction("Move", Move);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("radius", get_radius, set_radius);
		L.RegVar("height", get_height, set_height);
		L.RegVar("locked", get_locked, set_locked);
		L.RegVar("lockWhenNotMoving", get_lockWhenNotMoving, set_lockWhenNotMoving);
		L.RegVar("agentTimeHorizon", get_agentTimeHorizon, set_agentTimeHorizon);
		L.RegVar("obstacleTimeHorizon", get_obstacleTimeHorizon, set_obstacleTimeHorizon);
		L.RegVar("maxNeighbours", get_maxNeighbours, set_maxNeighbours);
		L.RegVar("layer", get_layer, set_layer);
		L.RegVar("collidesWith", get_collidesWith, set_collidesWith);
		L.RegVar("priority", get_priority, set_priority);
		L.RegVar("center", get_center, set_center);
		L.RegVar("debug", get_debug, set_debug);
		L.RegVar("movementPlane", get_movementPlane, null);
		L.RegFunction("getmovementPlane", get_movementPlane);
		L.RegVar("rvoAgent", get_rvoAgent, null);
		L.RegFunction("getrvoAgent", get_rvoAgent);
		L.RegVar("simulator", get_simulator, null);
		L.RegFunction("getsimulator", get_simulator);
		L.RegVar("position", get_position, null);
		L.RegFunction("getposition", get_position);
		L.RegVar("velocity", get_velocity, set_velocity);
		L.RegFunction("getvelocity", get_velocity);
		L.RegFunction("setvelocity", set_velocity);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int CalculateMovementDelta(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)ToLua.CheckObject<Pathfinding.RVO.RVOController>(L, 1);
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.Vector3 o = obj.CalculateMovementDelta(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)ToLua.CheckObject<Pathfinding.RVO.RVOController>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
				UnityEngine.Vector3 o = obj.CalculateMovementDelta(arg0, arg1);
				ToLua.Push(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.RVO.RVOController.CalculateMovementDelta");
			}
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
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)ToLua.CheckObject<Pathfinding.RVO.RVOController>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.SetCollisionNormal(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int To2D(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)ToLua.CheckObject<Pathfinding.RVO.RVOController>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				UnityEngine.Vector2 o = obj.To2D(arg0);
				ToLua.Push(L, o);
				return 1;
			}
			else if (count == 3)
			{
				Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)ToLua.CheckObject<Pathfinding.RVO.RVOController>(L, 1);
				UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
				float arg1;
				UnityEngine.Vector2 o = obj.To2D(arg0, out arg1);
				ToLua.Push(L, o);
				LuaDLL.lua_pushnumber(L, arg1);
				return 2;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: Pathfinding.RVO.RVOController.To2D");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int To3D(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)ToLua.CheckObject<Pathfinding.RVO.RVOController>(L, 1);
			UnityEngine.Vector2 arg0 = ToLua.ToVector2(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			UnityEngine.Vector3 o = obj.To3D(arg0, arg1);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTarget(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)ToLua.CheckObject<Pathfinding.RVO.RVOController>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
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
	static int Move(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)ToLua.CheckObject<Pathfinding.RVO.RVOController>(L, 1);
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.Move(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float ret = obj.radius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
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
	static int get_locked(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			bool ret = obj.locked;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index locked on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lockWhenNotMoving(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			bool ret = obj.lockWhenNotMoving;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lockWhenNotMoving on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_agentTimeHorizon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float ret = obj.agentTimeHorizon;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index agentTimeHorizon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_obstacleTimeHorizon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float ret = obj.obstacleTimeHorizon;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index obstacleTimeHorizon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_maxNeighbours(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			int ret = obj.maxNeighbours;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxNeighbours on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			Pathfinding.RVO.RVOLayer ret = obj.layer;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index layer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collidesWith(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			Pathfinding.RVO.RVOLayer ret = obj.collidesWith;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index collidesWith on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_priority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float ret = obj.priority;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index priority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_center(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float ret = obj.center;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index center on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_debug(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			bool ret = obj.debug;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index debug on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_movementPlane(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			Pathfinding.RVO.MovementPlane ret = obj.movementPlane;
			LuaDLL.lua_pushinteger(L, (int)ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index movementPlane on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rvoAgent(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			Pathfinding.RVO.IAgent ret = obj.rvoAgent;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rvoAgent on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_simulator(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			Pathfinding.RVO.Simulator ret = obj.simulator;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index simulator on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_position(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			UnityEngine.Vector3 ret = obj.position;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index position on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_velocity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			UnityEngine.Vector3 ret = obj.velocity;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index velocity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.radius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index radius on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_height(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.height = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index height on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_locked(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.locked = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index locked on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_lockWhenNotMoving(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.lockWhenNotMoving = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lockWhenNotMoving on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_agentTimeHorizon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.agentTimeHorizon = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index agentTimeHorizon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_obstacleTimeHorizon(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.obstacleTimeHorizon = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index obstacleTimeHorizon on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_maxNeighbours(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.maxNeighbours = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index maxNeighbours on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_layer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			Pathfinding.RVO.RVOLayer arg0 = (Pathfinding.RVO.RVOLayer)LuaDLL.luaL_checknumber(L, 2);
			obj.layer = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index layer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_collidesWith(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			Pathfinding.RVO.RVOLayer arg0 = (Pathfinding.RVO.RVOLayer)LuaDLL.luaL_checknumber(L, 2);
			obj.collidesWith = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index collidesWith on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_priority(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.priority = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index priority on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_center(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.center = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index center on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_debug(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.debug = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index debug on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_velocity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			Pathfinding.RVO.RVOController obj = (Pathfinding.RVO.RVOController)o;
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.velocity = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index velocity on a nil value");
		}
	}
}
