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
    public sealed class MobilePlatformApplicationConnectionQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplicationConnection, MobilePlatformApplicationConnectionQueryBuilder>
    {
        protected override MobilePlatformApplicationConnectionQueryBuilder Self => this;

        public MobilePlatformApplicationConnectionQueryBuilder() : this("mobilePlatformApplicationConnection")
        {
        }

        public MobilePlatformApplicationConnectionQueryBuilder(string name) : base(new Query<MobilePlatformApplicationConnection>(name))
        {
        }

        public MobilePlatformApplicationConnectionQueryBuilder(IQuery<MobilePlatformApplicationConnection> query) : base(query)
        {
        }

        public MobilePlatformApplicationConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MobilePlatformApplicationEdgeQueryBuilder> build)
        {
            var query = new Query<MobilePlatformApplicationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MobilePlatformApplicationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MobilePlatformApplicationEdge>(query);
            return this;
        }

        public MobilePlatformApplicationConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public MobilePlatformApplicationConnectionQueryBuilder Nodes(Action<MobilePlatformApplicationUnionCasesBuilder> build)
        {
            var query = new Query<MobilePlatformApplication>("nodes");
            var unionBuilder = new MobilePlatformApplicationUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}