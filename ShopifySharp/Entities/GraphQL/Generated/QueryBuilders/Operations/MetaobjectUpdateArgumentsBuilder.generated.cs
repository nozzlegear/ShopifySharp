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