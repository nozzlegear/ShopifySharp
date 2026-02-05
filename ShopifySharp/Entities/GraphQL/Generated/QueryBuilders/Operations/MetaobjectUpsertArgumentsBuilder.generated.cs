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
    public sealed class MetaobjectUpsertArgumentsBuilder : ArgumentsBuilderBase<MetaobjectUpsertPayload, MetaobjectUpsertArgumentsBuilder>
    {
        protected override MetaobjectUpsertArgumentsBuilder Self => this;

        public MetaobjectUpsertArgumentsBuilder(IQuery<MetaobjectUpsertPayload> query) : base(query)
        {
        }

        public MetaobjectUpsertArgumentsBuilder Handle(MetaobjectHandleInput? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }

        public MetaobjectUpsertArgumentsBuilder Metaobject(MetaobjectUpsertInput? metaobject)
        {
            base.InnerQuery.AddArgument("metaobject", metaobject);
            return this;
        }
    }
}