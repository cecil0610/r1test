using System;
using System.Net.Http;
using Microsoft.Azure.AppService;

namespace AjaxModuleTest
{
    public static class ConsotoApitestAppServiceExtensions
    {
        public static ConsotoApitest CreateConsotoApitest(this IAppServiceClient client)
        {
            return new ConsotoApitest(client.CreateHandler());
        }

        public static ConsotoApitest CreateConsotoApitest(this IAppServiceClient client, params DelegatingHandler[] handlers)
        {
            return new ConsotoApitest(client.CreateHandler(handlers));
        }

        public static ConsotoApitest CreateConsotoApitest(this IAppServiceClient client, Uri uri, params DelegatingHandler[] handlers)
        {
            return new ConsotoApitest(uri, client.CreateHandler(handlers));
        }

        public static ConsotoApitest CreateConsotoApitest(this IAppServiceClient client, HttpClientHandler rootHandler, params DelegatingHandler[] handlers)
        {
            return new ConsotoApitest(rootHandler, client.CreateHandler(handlers));
        }
    }
}
