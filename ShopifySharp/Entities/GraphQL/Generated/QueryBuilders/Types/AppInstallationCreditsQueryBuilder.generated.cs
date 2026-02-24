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
    public sealed class AppInstallationCreditsQueryBuilder : FieldsQueryBuilderBase<AppCreditConnection, AppInstallationCreditsQueryBuilder>, IHasArguments<AppInstallationCreditsArgumentsBuilder>
    {
        public AppInstallationCreditsArgumentsBuilder Arguments { get; }
        protected override AppInstallationCreditsQueryBuilder Self => this;

        public AppInstallationCreditsQueryBuilder(string name) : base(new Query<AppCreditConnection>(name))
        {
            Arguments = new AppInstallationCreditsArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationCreditsQueryBuilder(IQuery<AppCreditConnection> query) : base(query)
        {
            Arguments = new AppInstallationCreditsArgumentsBuilder(base.InnerQuery);
        }

        public AppInstallationCreditsQueryBuilder SetArguments(Action<AppInstallationCreditsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AppInstallationCreditsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppCreditEdgeQueryBuilder> build)
        {
            var query = new Query<AppCreditEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppCreditEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppCreditEdge>(query);
            return this;
        }

        public AppInstallationCreditsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppCreditQueryBuilder> build)
        {
            var query = new Query<AppCredit>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppCreditQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppCredit>(query);
            return this;
        }

        public AppInstallationCreditsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}