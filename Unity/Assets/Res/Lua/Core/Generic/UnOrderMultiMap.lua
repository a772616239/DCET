-- Generated by CSharp.lua Compiler
local System = System
local Linq = System.Linq.Enumerable
System.namespace("DCET", function (namespace)
  namespace.class("UnOrderMultiMap_2", function (namespace)
    return function (T, K)
      local GetDictionary, Add, First, getCount, FetchList, RecycleList, Remove, Remove1, 
      GetAll, get, GetOne, Contains, ContainsKey, Clear, __ctor__
      local ListK = System.List(K)
      local ArrayK = System.Array(K)
      local DictTListK = System.Dictionary(T, ListK)
      local QueueListK = System.Queue(ListK)
      __ctor__ = function (this)
        this.dictionary = DictTListK()
        this.queue = QueueListK()
      end
      GetDictionary = function (this)
        return this.dictionary
      end
      Add = function (this, t, k)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list == nil then
          list = FetchList(this)
          this.dictionary:set(t, list)
        end
        list:Add(k)
      end
      First = function (this)
        return Linq.First(this.dictionary)
      end
      getCount = function (this)
        return this.dictionary:getCount()
      end
      FetchList = function (this)
        if #this.queue > 0 then
          local list = this.queue:Dequeue()
          list:Clear()
          return list
        end
        return ListK()
      end
      RecycleList = function (this, list)
        -- 防止暴涨
        if #this.queue > 100 then
          return
        end
        list:Clear()
        this.queue:Enqueue(list)
      end
      Remove = function (this, t, k)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list == nil then
          return false
        end
        if not list:Remove(k) then
          return false
        end
        if #list == 0 then
          RecycleList(this, list)
          this.dictionary:RemoveKey(t)
        end
        return true
      end
      Remove1 = function (this, t)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list ~= nil then
          RecycleList(this, list)
        end
        return this.dictionary:RemoveKey(t)
      end
      -- <summary>
      -- 不返回内部的list,copy一份出来
      -- </summary>
      -- <returns></returns>
      GetAll = function (this, t)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list == nil then
          return ArrayK:new(0)
        end
        return list:ToArray()
      end
      get = function (this, t)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        return list
      end
      GetOne = function (this, t)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list ~= nil and #list > 0 then
          return list:get(0)
        end
        return System.default(K)
      end
      Contains = function (this, t, k)
        local list
        local _
        _, list = this.dictionary:TryGetValue(t)
        if list == nil then
          return false
        end
        return list:Contains(k)
      end
      ContainsKey = function (this, t)
        return this.dictionary:ContainsKey(t)
      end
      Clear = function (this)
        for _, keyValuePair in System.each(this.dictionary) do
          RecycleList(this, keyValuePair.Value)
        end
        this.dictionary:Clear()
      end
      return {
        GetDictionary = GetDictionary,
        Add = Add,
        First = First,
        getCount = getCount,
        Remove = Remove,
        Remove1 = Remove1,
        GetAll = GetAll,
        get = get,
        GetOne = GetOne,
        Contains = Contains,
        ContainsKey = ContainsKey,
        Clear = Clear,
        __ctor__ = __ctor__
      }
    end
  end)
end)