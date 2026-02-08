#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PubSubServerPixelUpdateArgumentsBuilder : ArgumentsBuilderBase<PubSubServerPixelUpdatePayload, PubSubServerPixelUpdateArgumentsBuilder>
    {
        protected override PubSubServerPixelUpdateArgumentsBuilder Self => this;

        public PubSubServerPixelUpdateArgumentsBuilder(IQuery<PubSubServerPixelUpdatePayload> query) : base(query)
        {
        }

        public PubSubServerPixelUpdateArgumentsBuilder PubSubProject(string? pubSubProject)
        {
            base.InnerQuery.AddArgument("pubSubProject", pubSubProject);
            return this;
        }

        public PubSubServerPixelUpdateArgumentsBuilder PubSubTopic(string? pubSubTopic)
        {
            base.InnerQuery.AddArgument("pubSubTopic", pubSubTopic);
            return this;
        }
    }
}