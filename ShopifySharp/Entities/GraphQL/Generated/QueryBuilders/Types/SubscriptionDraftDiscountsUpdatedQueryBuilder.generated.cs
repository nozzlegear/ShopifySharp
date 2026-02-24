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
    public sealed class SubscriptionDraftDiscountsUpdatedQueryBuilder : FieldsQueryBuilderBase<SubscriptionDiscountConnection, SubscriptionDraftDiscountsUpdatedQueryBuilder>, IHasArguments<SubscriptionDraftDiscountsUpdatedArgumentsBuilder>
    {
        public SubscriptionDraftDiscountsUpdatedArgumentsBuilder Arguments { get; }
        protected override SubscriptionDraftDiscountsUpdatedQueryBuilder Self => this;

        public SubscriptionDraftDiscountsUpdatedQueryBuilder(string name) : base(new Query<SubscriptionDiscountConnection>(name))
        {
            Arguments = new SubscriptionDraftDiscountsUpdatedArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountsUpdatedQueryBuilder(IQuery<SubscriptionDiscountConnection> query) : base(query)
        {
            Arguments = new SubscriptionDraftDiscountsUpdatedArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionDraftDiscountsUpdatedQueryBuilder SetArguments(Action<SubscriptionDraftDiscountsUpdatedArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SubscriptionDraftDiscountsUpdatedQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountEdgeQueryBuilder> build)
        {
            var query = new Query<SubscriptionDiscountEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDiscountEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDiscountEdge>(query);
            return this;
        }

        public SubscriptionDraftDiscountsUpdatedQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public SubscriptionDraftDiscountsUpdatedQueryBuilder Nodes(Action<SubscriptionDiscountUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDiscount>("nodes");
            var unionBuilder = new SubscriptionDiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}