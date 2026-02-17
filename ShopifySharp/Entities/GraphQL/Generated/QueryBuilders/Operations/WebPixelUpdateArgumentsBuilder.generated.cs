#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class WebPixelUpdateArgumentsBuilder : ArgumentsBuilderBase<WebPixelUpdatePayload, WebPixelUpdateArgumentsBuilder>
    {
        protected override WebPixelUpdateArgumentsBuilder Self => this;

        public WebPixelUpdateArgumentsBuilder(IQuery<WebPixelUpdatePayload> query) : base(query)
        {
        }

        public WebPixelUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public WebPixelUpdateArgumentsBuilder WebPixel(WebPixelInput? webPixel)
        {
            base.InnerQuery.AddArgument("webPixel", webPixel);
            return this;
        }
    }
}