using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OZTF.EducationManageSys.Config
{
    /// <summary>
    /// 重组url，使用consul服务发现
    /// </summary>
    public class ServiceDiscoveryMessageHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
