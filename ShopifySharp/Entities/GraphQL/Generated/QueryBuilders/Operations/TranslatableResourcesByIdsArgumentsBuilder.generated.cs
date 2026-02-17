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
    public sealed class TranslatableResourcesByIdsArgumentsBuilder : ArgumentsBuilderBase<TranslatableResourceConnection, TranslatableResourcesByIdsArgumentsBuilder>
    {
        protected override TranslatableResourcesByIdsArgumentsBuilder Self => this;

        public TranslatableResourcesByIdsArgumentsBuilder(IQuery<TranslatableResourceConnection> query) : base(query)
        {
        }

        public TranslatableResourcesByIdsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public TranslatableResourcesByIdsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public TranslatableResourcesByIdsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public TranslatableResourcesByIdsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public TranslatableResourcesByIdsArgumentsBuilder ResourceIds(ICollection<string>? resourceIds)
        {
            base.InnerQuery.AddArgument("resourceIds", resourceIds);
            return this;
        }

        public TranslatableResourcesByIdsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}