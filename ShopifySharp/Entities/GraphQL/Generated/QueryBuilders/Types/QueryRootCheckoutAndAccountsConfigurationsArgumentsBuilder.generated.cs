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
    public sealed class QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder : ArgumentsBuilderBase<CheckoutAndAccountsConfigurationConnection?, QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder>
    {
        protected override QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder Self => this;

        public QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder(IQuery<CheckoutAndAccountsConfigurationConnection?> query) : base(query)
        {
        }

        public QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootCheckoutAndAccountsConfigurationsArgumentsBuilder SortKey(CheckoutAndAccountsConfigurationsGraphQLSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}