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
    public sealed class MetaobjectUpdateArgumentsBuilder : ArgumentsBuilderBase<MetaobjectUpdatePayload, MetaobjectUpdateArgumentsBuilder>
    {
        protected override MetaobjectUpdateArgumentsBuilder Self => this;

        public MetaobjectUpdateArgumentsBuilder(IQuery<MetaobjectUpdatePayload> query) : base(query)
        {
        }

        public MetaobjectUpdateArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }

        public MetaobjectUpdateArgumentsBuilder Metaobject(MetaobjectUpdateInput? metaobject)
        {
            base.InnerQuery.AddArgument("metaobject", metaobject);
            return this;
        }
    }
}