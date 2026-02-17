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
    public sealed class MetaobjectCreateArgumentsBuilder : ArgumentsBuilderBase<MetaobjectCreatePayload, MetaobjectCreateArgumentsBuilder>
    {
        protected override MetaobjectCreateArgumentsBuilder Self => this;

        public MetaobjectCreateArgumentsBuilder(IQuery<MetaobjectCreatePayload> query) : base(query)
        {
        }

        public MetaobjectCreateArgumentsBuilder Metaobject(MetaobjectCreateInput? metaobject)
        {
            base.InnerQuery.AddArgument("metaobject", metaobject);
            return this;
        }
    }
}