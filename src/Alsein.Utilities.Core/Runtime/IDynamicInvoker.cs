using System;
using System.Reflection;

namespace Alsein.Utilities.Runtime
{
    /// <summary>
    /// 
    /// </summary>
    public interface IDynamicInvoker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="method"></param>
        /// <param name="valueArgs"></param>
        /// <returns></returns>
        object Invoke(MethodInfo method, params object[] valueArgs);
    }
}