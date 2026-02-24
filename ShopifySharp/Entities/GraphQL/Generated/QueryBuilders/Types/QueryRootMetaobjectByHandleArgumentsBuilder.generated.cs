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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootMetaobjectByHandleArgumentsBuilder : ArgumentsBuilderBase<Metaobject?, QueryRootMetaobjectByHandleArgumentsBuilder>
    {
        protected override QueryRootMetaobjectByHandleArgumentsBuilder Self => this;

        public QueryRootMetaobjectByHandleArgumentsBuilder(IQuery<Metaobject?> query) : base(query)
        {
        }

        public QueryRootMetaobjectByHandleArgumentsBuilder Handle(MetaobjectHandleInput? handle)
        {
            base.InnerQuery.AddArgument("handle", handle);
            return this;
        }
    }
}