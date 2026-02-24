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
    public sealed class AppInstallationOneTimePurchasesArgumentsBuilder : ArgumentsBuilderBase<AppPurchaseOneTimeConnection?, AppInstallationOneTimePurchasesArgumentsBuilder>
    {
        protected override AppInstallationOneTimePurchasesArgumentsBuilder Self => this;

        public AppInstallationOneTimePurchasesArgumentsBuilder(IQuery<AppPurchaseOneTimeConnection?> query) : base(query)
        {
        }

        public AppInstallationOneTimePurchasesArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AppInstallationOneTimePurchasesArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AppInstallationOneTimePurchasesArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AppInstallationOneTimePurchasesArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AppInstallationOneTimePurchasesArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public AppInstallationOneTimePurchasesArgumentsBuilder SortKey(AppTransactionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}