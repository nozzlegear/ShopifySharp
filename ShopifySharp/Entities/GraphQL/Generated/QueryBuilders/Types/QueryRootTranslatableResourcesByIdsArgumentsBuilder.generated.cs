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
    public sealed class QueryRootTranslatableResourcesByIdsArgumentsBuilder : ArgumentsBuilderBase<TranslatableResourceConnection?, QueryRootTranslatableResourcesByIdsArgumentsBuilder>
    {
        protected override QueryRootTranslatableResourcesByIdsArgumentsBuilder Self => this;

        public QueryRootTranslatableResourcesByIdsArgumentsBuilder(IQuery<TranslatableResourceConnection?> query) : base(query)
        {
        }

        public QueryRootTranslatableResourcesByIdsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootTranslatableResourcesByIdsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootTranslatableResourcesByIdsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootTranslatableResourcesByIdsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootTranslatableResourcesByIdsArgumentsBuilder ResourceIds(ICollection<string>? resourceIds)
        {
            base.InnerQuery.AddArgument("resourceIds", resourceIds);
            return this;
        }

        public QueryRootTranslatableResourcesByIdsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}