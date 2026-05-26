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
    public sealed class CheckoutAndAccountsConfigurationConnectionArgumentsBuilder : ArgumentsBuilderBase<CheckoutAndAccountsConfigurationConnection, CheckoutAndAccountsConfigurationConnectionArgumentsBuilder>
    {
        protected override CheckoutAndAccountsConfigurationConnectionArgumentsBuilder Self => this;

        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder(IQuery<CheckoutAndAccountsConfigurationConnection> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CheckoutAndAccountsConfigurationConnectionArgumentsBuilder SortKey(CheckoutAndAccountsConfigurationsGraphQLSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}