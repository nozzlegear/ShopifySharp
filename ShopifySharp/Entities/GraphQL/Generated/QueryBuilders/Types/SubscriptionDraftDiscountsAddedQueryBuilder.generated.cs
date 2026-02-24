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
    public sealed class SubscriptionDraftDiscountsAddedQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountConnection, SubscriptionDraftDiscountsAddedQueryBuilder>, IHasArguments<SubscriptionDraftDiscountsAddedArgumentsBuilder>
    {
        public SubscriptionDraftDiscountsAddedArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftDiscountsAddedQueryBuilder Self => this;

        public SubscriptionDraftDiscountsAddedQueryBuilder(string name) : base(new Query<SubscriptionDiscountConnection>(name))
        {
            Arguments = new SubscriptionDraftDiscountsAddedArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountsAddedQueryBuilder(IQuery<SubscriptionDiscountConnection> query) : base(query)
        {
            Arguments = new SubscriptionDraftDiscountsAddedArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountsAddedQueryBuilder SetArguments(Action<SubscriptionDraftDiscountsAddedArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionDraftDiscountsAddedQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountEdge>(query);
            return this;
        }

        public SubscriptionDraftDiscountsAddedQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public SubscriptionDraftDiscountsAddedQueryBuilder Nodes(Action<SubscriptionDiscountUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscount>("nodes");
            var unionBuilder = new SubscriptionDiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}