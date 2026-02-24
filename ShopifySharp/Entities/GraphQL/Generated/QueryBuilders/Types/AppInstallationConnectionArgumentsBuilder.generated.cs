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
    public sealed class AppInstallationConnectionArgumentsBuilder : ArgumentsBuilderBase<AppInstallationConnection, AppInstallationConnectionArgumentsBuilder>
    {
        protected override AppInstallationConnectionArgumentsBuilder Self => this;

        public AppInstallationConnectionArgumentsBuilder(IQuery<AppInstallationConnection> query) : base(query)
        {
        }

        public AppInstallationConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AppInstallationConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AppInstallationConnectionArgumentsBuilder Category(AppInstallationCategory? category)
        {
            base.InnerQuery.AddArgument("category", category);
            return this;
        }

        public AppInstallationConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AppInstallationConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AppInstallationConnectionArgumentsBuilder Privacy(AppInstallationPrivacy? privacy)
        {
            base.InnerQuery.AddArgument("privacy", privacy);
            return this;
        }

        public AppInstallationConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public AppInstallationConnectionArgumentsBuilder SortKey(AppInstallationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}