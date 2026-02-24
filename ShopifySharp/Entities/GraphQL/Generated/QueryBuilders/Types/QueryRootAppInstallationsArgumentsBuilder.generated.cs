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
    public sealed class QueryRootAppInstallationsArgumentsBuilder : ArgumentsBuilderBase<AppInstallationConnection?, QueryRootAppInstallationsArgumentsBuilder>
    {
        protected override QueryRootAppInstallationsArgumentsBuilder Self => this;

        public QueryRootAppInstallationsArgumentsBuilder(IQuery<AppInstallationConnection?> query) : base(query)
        {
        }

        public QueryRootAppInstallationsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootAppInstallationsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootAppInstallationsArgumentsBuilder Category(AppInstallationCategory? category)
        {
            base.InnerQuery.AddArgument("category", category);
            return this;
        }

        public QueryRootAppInstallationsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootAppInstallationsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootAppInstallationsArgumentsBuilder Privacy(AppInstallationPrivacy? privacy)
        {
            base.InnerQuery.AddArgument("privacy", privacy);
            return this;
        }

        public QueryRootAppInstallationsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootAppInstallationsArgumentsBuilder SortKey(AppInstallationSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}