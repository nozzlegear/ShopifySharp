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
    public sealed class QueryRootOrderAttributionDefinitionsArgumentsBuilder : ArgumentsBuilderBase<OrderAttributionDefinitionConnection?, QueryRootOrderAttributionDefinitionsArgumentsBuilder>
    {
        protected override QueryRootOrderAttributionDefinitionsArgumentsBuilder Self => this;

        public QueryRootOrderAttributionDefinitionsArgumentsBuilder(IQuery<OrderAttributionDefinitionConnection?> query) : base(query)
        {
        }

        public QueryRootOrderAttributionDefinitionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootOrderAttributionDefinitionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootOrderAttributionDefinitionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootOrderAttributionDefinitionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootOrderAttributionDefinitionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}