-- Generated by CSharp.lua Compiler
local System = System
local Linq = System.Linq.Enumerable
local DCETModel = DCET.Model
local FairyGUI = FairyGUI
local DCETHotfix
local DictStringFUI
System.import(function (out)
  DCETHotfix = DCET.Hotfix
  DictStringFUI = System.Dictionary(System.String, DCETHotfix.FUI)
end)
System.namespace("DCET.Hotfix", function (namespace)
  namespace.class("FUIAwakeSystem", function (namespace)
    local Awake
    Awake = function (this, self, gObject)
      self.GObject = gObject
    end
    return {
      __inherits__ = function (out)
        return {
          out.DCET.Hotfix.AwakeSystem_2(out.DCET.Hotfix.FUI, out.FairyGUI.GObject)
        }
      end,
      Awake = Awake
    }
  end)

  namespace.class("FUI", function (namespace)
    local getName, setName, getVisible, setVisible, getIsWindow, getIsComponent, getIsRoot, getIsEmpty, 
    Dispose, Add, MakeFullScreen, Remove, RemoveNoDispose, RemoveChildren, Get, GetAll, 
    class, __ctor__
    __ctor__ = function (this)
      this.children = DictStringFUI()
      System.base(this).__ctor__(this)
    end
    getName = function (this)
      if this.GObject == nil then
        return ("")
      end

      return this.GObject.name
    end
    setName = function (this, value)
      if this.GObject == nil then
        return
      end

      this.GObject.name = value
    end
    getVisible = function (this)
      if this.GObject == nil then
        return false
      end

      return this.GObject:getvisible()
    end
    setVisible = function (this, value)
      if this.GObject == nil then
        return
      end

      this.GObject:setvisible(value)
    end
    getIsWindow = function (this)
      return System.is(this.GObject, DCETModel.GWindow)
    end
    getIsComponent = function (this)
      return System.is(this.GObject, FairyGUI.GComponent)
    end
    getIsRoot = function (this)
      return System.is(this.GObject, FairyGUI.GRoot)
    end
    getIsEmpty = function (this)
      return this.GObject == nil
    end
    Dispose = function (this)
      if this:getIsDisposed() then
        return
      end

      System.base(this).Dispose(this)

      -- 从父亲中删除自己
      local default = this:GetParent(class)
      if default ~= nil then
        RemoveNoDispose(default, getName(this))
      end

      -- 删除所有的孩子
      for _, ui in System.each(Linq.ToArray(this.children:getValues())) do
        Dispose(ui)
      end

      this.children:Clear()

      -- 删除自己的UI
      if not getIsRoot(this) and not this.isFromFGUIPool then
        this.GObject:Dispose()
      end

      this.GObject = nil
      this.isFromFGUIPool = false
    end
    Add = function (this, ui, asChildGObject)
      if ui == nil or getIsEmpty(ui) then
        System.throw(System.Exception("ui can not be empty" .. ""))
      end

      if System.String.IsNullOrWhiteSpace(getName(ui)) then
        System.throw(System.Exception("ui.Name can not be empty" .. ""))
      end

      if this.children:ContainsKey(getName(ui)) then
        System.throw(System.Exception("ui.Name(" .. getName(ui) .. ") already exist"))
      end

      this.children:AddKeyValue(getName(ui), ui)

      if getIsComponent(this) and asChildGObject then
        this.GObject:getasCom():AddChild(ui.GObject)
      end

      ui:setParent(this)
    end
    MakeFullScreen = function (this)
      local default = this.GObject
      if default ~= nil then
        default = default:getasCom()
        if default ~= nil then
          default = default:MakeFullScreen()
        end
      end
    end
    Remove = function (this, name)
      if this:getIsDisposed() then
        return
      end

      local ui

      local default
      default, ui = this.children:TryGetValue(name)
      if default then
        this.children:RemoveKey(name)

        if ui ~= nil then
          if getIsComponent(this) then
            this.GObject:getasCom():RemoveChild(ui.GObject, false)
          end

          ui:setParent(nil)
          Dispose(ui)
        end
      end
    end
    -- <summary>
    -- 一般情况不要使用此方法，如需使用，需要自行管理返回值的FUI的释放。
    -- </summary>
    RemoveNoDispose = function (this, name)
      if this:getIsDisposed() then
        return nil
      end

      local ui

      local default
      default, ui = this.children:TryGetValue(name)
      if default then
        this.children:RemoveKey(name)

        if ui ~= nil then
          if getIsComponent(this) then
            this.GObject:getasCom():RemoveChild(ui.GObject, false)
          end

          ui:setParent(nil)
        end
      end

      return ui
    end
    RemoveChildren = function (this)
      for _, child in System.each(Linq.ToArray(this.children:getValues())) do
        Dispose(child)
      end

      this.children:Clear()
    end
    Get = function (this, name)
      local child

      local default
      default, child = this.children:TryGetValue(name)
      if default then
        return child
      end

      return nil
    end
    GetAll = function (this)
      return Linq.ToArray(this.children:getValues())
    end
    class = {
      __inherits__ = function (out)
        return {
          out.DCET.Hotfix.Entity
        }
      end,
      getName = getName,
      setName = setName,
      getVisible = getVisible,
      setVisible = setVisible,
      getIsWindow = getIsWindow,
      getIsComponent = getIsComponent,
      getIsRoot = getIsRoot,
      getIsEmpty = getIsEmpty,
      isFromFGUIPool = false,
      Dispose = Dispose,
      Add = Add,
      MakeFullScreen = MakeFullScreen,
      Remove = Remove,
      RemoveNoDispose = RemoveNoDispose,
      RemoveChildren = RemoveChildren,
      Get = Get,
      GetAll = GetAll,
      __ctor__ = __ctor__
    }
    return class
  end)
end)