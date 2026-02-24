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
    public sealed class QueryRootAbandonmentArgumentsBuilder : ArgumentsBuilderBase<Abandonment?, QueryRootAbandonmentArgumentsBuilder>
    {
        protected override QueryRootAbandonmentArgumentsBuilder Self => this;

        public QueryRootAbandonmentArgumentsBuilder(IQuery<Abandonment?> query) : base(query)
        {
        }

        public QueryRootAbandonmentArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}