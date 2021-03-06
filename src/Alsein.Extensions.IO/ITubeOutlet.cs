using System;
using System.Threading.Tasks;

namespace Alsein.Extensions.IO
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITubeOutlet : IDisposableWithStatus
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<TData> ReceiveAsync<TData>();

        /// <summary>
        /// 
        /// </summary>
        event Func<TubeReceiveEventArgs, Task> Receive;
    }
}