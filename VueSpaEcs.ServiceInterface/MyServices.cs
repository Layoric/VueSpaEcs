using System;
using ServiceStack;
using VueSpaEcs.ServiceModel;

namespace VueSpaEcs.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
