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
    public sealed class StoreCreditAccountTransactionConnectionArgumentsBuilder : ArgumentsBuilderBase<StoreCreditAccountTransactionConnection, StoreCreditAccountTransactionConnectionArgumentsBuilder>
    {
        protected override StoreCreditAccountTransactionConnectionArgumentsBuilder Self => this;

        public StoreCreditAccountTransactionConnectionArgumentsBuilder(IQuery<StoreCreditAccountTransactionConnection> query) : base(query)
        {
        }

        public StoreCreditAccountTransactionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public StoreCreditAccountTransactionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public StoreCreditAccountTransactionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public StoreCreditAccountTransactionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public StoreCreditAccountTransactionConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public StoreCreditAccountTransactionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public StoreCreditAccountTransactionConnectionArgumentsBuilder SortKey(TransactionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}