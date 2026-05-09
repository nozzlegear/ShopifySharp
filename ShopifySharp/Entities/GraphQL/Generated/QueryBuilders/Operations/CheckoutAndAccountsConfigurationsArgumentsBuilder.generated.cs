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
    public sealed class CheckoutAndAccountsConfigurationsArgumentsBuilder : ArgumentsBuilderBase<CheckoutAndAccountsConfigurationConnection, CheckoutAndAccountsConfigurationsArgumentsBuilder>
    {
        protected override CheckoutAndAccountsConfigurationsArgumentsBuilder Self => this;

        public CheckoutAndAccountsConfigurationsArgumentsBuilder(IQuery<CheckoutAndAccountsConfigurationConnection> query) : base(query)
        {
        }

        public CheckoutAndAccountsConfigurationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CheckoutAndAccountsConfigurationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CheckoutAndAccountsConfigurationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CheckoutAndAccountsConfigurationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CheckoutAndAccountsConfigurationsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CheckoutAndAccountsConfigurationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CheckoutAndAccountsConfigurationsArgumentsBuilder SortKey(CheckoutAndAccountsConfigurationsGraphQLSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}