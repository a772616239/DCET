﻿namespace DCET
{
	public static class JsonHelper
	{
		public static string ToJson(object obj)
		{
#if __CSharpLua__
			string t = null;
		/*
		[[
			t = UnityEngine.JsonUtility.ToJson(obj)
		]]
		*/
			return t;
#else
			return DCETRuntime.MongoHelper.ToJson(obj);
#endif
		}

		public static T FromJson<T>(string str)
		{
#if __CSharpLua__
			T t = default(T);
		/*
		[[
			t = UnityEngine.JsonUtility.FromJson(str, T)
		]]
		*/
			return t;	
#else
			return DCETRuntime.MongoHelper.FromJson<T>(str);
#endif
		}
	}
}