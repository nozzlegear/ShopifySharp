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
    public sealed class MetafieldReferenceTransactionsArgumentsBuilder : ArgumentsBuilderBase<OrderTransaction?, MetafieldReferenceTransactionsArgumentsBuilder>
    {
        protected override MetafieldReferenceTransactionsArgumentsBuilder Self => this;

        public MetafieldReferenceTransactionsArgumentsBuilder(IQuery<OrderTransaction?> query) : base(query)
        {
        }

        public MetafieldReferenceTransactionsArgumentsBuilder Capturable(bool? capturable)
        {
            base.InnerQuery.AddArgument("capturable", capturable);
            return this;
        }

        public MetafieldReferenceTransactionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public MetafieldReferenceTransactionsArgumentsBuilder ManuallyResolvable(bool? manuallyResolvable)
        {
            base.InnerQuery.AddArgument("manuallyResolvable", manuallyResolvable);
            return this;
        }
    }
}