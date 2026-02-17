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
    public sealed class AppInstallationsArgumentsBuilder : ArgumentsBuilderBase<AppInstallationConnection, AppInstallationsArgumentsBuilder>
    {
        protected override AppInstallationsArgumentsBuilder Self => this;

        public AppInstallationsArgumentsBuilder(IQuery<AppInstallationConnection> query) : base(query)
        {
        }

        public AppInstallationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AppInstallationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AppInstallationsArgumentsBuilder Category(AppInstallationCategory? category)
        {
            base.InnerQuery.AddArgument("category", category);
            return this;
        }

        public AppInstallationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AppInstallationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AppInstallationsArgumentsBuilder Privacy(AppInstallationPrivacy? privacy)
        {
            base.InnerQuery.AddArgument("privacy", privacy);
            return this;
        }

        public AppInstallationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public AppInstallationsArgumentsBuilder SortKey(AppInstallationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}