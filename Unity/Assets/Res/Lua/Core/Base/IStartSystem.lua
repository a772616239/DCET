-- Generated by CSharp.lua Compiler
local System = System
System.namespace("DCET", function (namespace)
  namespace.interface("IStartSystem", function ()
    return {}
  end)

  namespace.class("StartSystem_1", function (namespace)
    return function (T)
      local Run, Type
      Run = function (this, o)
        this:Start(System.cast(T, o))
      end
      Type = function (this)
        return System.typeof(T)
      end
      return {
        base = function (out)
          return {
            out.DCET.IStartSystem
          }
        end,
        Run = Run,
        Type = Type
      }
    end
  end)
end)
