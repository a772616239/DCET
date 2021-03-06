-- Generated by CSharp.lua Compiler
local System = System
System.namespace("DCET", function (namespace)
  namespace.class("Scene", function (namespace)
    local Get, getDomain1, setDomain1, getParent1, setParent1, class, __ctor__
    __ctor__ = function (this)
      System.base(this).__ctor__(this)
    end
    Get = function (this, id)
      return System.cast(class, this:getChildren():get(id))
    end
    getDomain1 = function (this)
      return this.domain
    end
    setDomain1 = function (this, value)
      this.domain = value
    end
    getParent1 = function (this)
      return this.parent
    end
    setParent1 = function (this, value)
      this.parent = value
      this.parent:getChildren():AddKeyValue(this.Id, this)

      if UnityEngine.op_Inequality(this.ViewGO, nil) and UnityEngine.op_Inequality(this.parent.ViewGO, nil) then
        this.ViewGO:gettransform():SetParent(this.parent.ViewGO:gettransform(), false)
      end
    end
    class = {
      base = function (out)
        return {
          out.DCET.Entity
        }
      end,
      SceneType = 0,
      Get = Get,
      getDomain1 = getDomain1,
      setDomain1 = setDomain1,
      getParent1 = getParent1,
      setParent1 = setParent1,
      __ctor__ = __ctor__
    }
    return class
  end)
end)
