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
    public sealed class PriceRuleItemEntitlementsCollectionsQueryBuilder : FieldsQueryBuilderBase<CollectionConnection, PriceRuleItemEntitlementsCollectionsQueryBuilder>, IHasArguments<PriceRuleItemEntitlementsCollectionsArgumentsBuilder>
    {
        public PriceRuleItemEntitlementsCollectionsArgumentsBuilder Arguments { get; }
        protected override PriceRuleItemEntitlementsCollectionsQueryBuilder Self => this;

        public PriceRuleItemEntitlementsCollectionsQueryBuilder(string name) : base(new Query<CollectionConnection>(name))
        {
            Arguments = new PriceRuleItemEntitlementsCollectionsArgumentsBuilder(base.InnerQuery);
        }

        public PriceRuleItemEntitlementsCollectionsQueryBuilder(IQuery<CollectionConnection> query) : base(query)
        {
            Arguments = new PriceRuleItemEntitlementsCollectionsArgumentsBuilder(base.InnerQuery);
        }

        public PriceRuleItemEntitlementsCollectionsQueryBuilder SetArguments(Action<PriceRuleItemEntitlementsCollectionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public PriceRuleItemEntitlementsCollectionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionEdgeQueryBuilder> build)
        {
            var query = new Query<CollectionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionEdge>(query);
            return this;
        }

        public PriceRuleItemEntitlementsCollectionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder> build)
        {
            var query = new Query<Collection>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Collection>(query);
            return this;
        }

        public PriceRuleItemEntitlementsCollectionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}