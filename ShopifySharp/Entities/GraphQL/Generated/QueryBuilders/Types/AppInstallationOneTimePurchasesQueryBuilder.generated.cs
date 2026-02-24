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
    public sealed class AppInstallationOneTimePurchasesQueryBuilder : FieldsQueryBuilderBase<AppPurchaseOneTimeConnection, AppInstallationOneTimePurchasesQueryBuilder>, IHasArguments<AppInstallationOneTimePurchasesArgumentsBuilder>
    {
        public AppInstallationOneTimePurchasesArgumentsBuilder Arguments { get; }
        protected override AppInstallationOneTimePurchasesQueryBuilder Self => this;

        public AppInstallationOneTimePurchasesQueryBuilder(string name) : base(new Query<AppPurchaseOneTimeConnection>(name))
        {
            Arguments = new AppInstallationOneTimePurchasesArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationOneTimePurchasesQueryBuilder(IQuery<AppPurchaseOneTimeConnection> query) : base(query)
        {
            Arguments = new AppInstallationOneTimePurchasesArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationOneTimePurchasesQueryBuilder SetArguments(Action<AppInstallationOneTimePurchasesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AppInstallationOneTimePurchasesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeEdgeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTimeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTimeEdge>(query);
            return this;
        }

        public AppInstallationOneTimePurchasesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder> build)
        {
            var query = new Query<AppPurchaseOneTime>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppPurchaseOneTimeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppPurchaseOneTime>(query);
            return this;
        }

        public AppInstallationOneTimePurchasesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}