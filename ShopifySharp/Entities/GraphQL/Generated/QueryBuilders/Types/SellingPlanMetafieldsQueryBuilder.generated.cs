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
    public sealed class SellingPlanMetafieldsQueryBuilder : FieldsQueryBuilderBase<MetafieldConnection, SellingPlanMetafieldsQueryBuilder>, IHasArguments<SellingPlanMetafieldsArgumentsBuilder>
    {
        public SellingPlanMetafieldsArgumentsBuilder Arguments { get; }
        protected override SellingPlanMetafieldsQueryBuilder Self => this;

        public SellingPlanMetafieldsQueryBuilder(string name) : base(new Query<MetafieldConnection>(name))
        {
            Arguments = new SellingPlanMetafieldsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanMetafieldsQueryBuilder(IQuery<MetafieldConnection> query) : base(query)
        {
            Arguments = new SellingPlanMetafieldsArgumentsBuilder(base.InnerQuery);
        }

        public SellingPlanMetafieldsQueryBuilder SetArguments(Action<SellingPlanMetafieldsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SellingPlanMetafieldsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldEdgeQueryBuilder> build)
        {
            var query = new Query<MetafieldEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldEdge>(query);
            return this;
        }

        public SellingPlanMetafieldsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public SellingPlanMetafieldsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}