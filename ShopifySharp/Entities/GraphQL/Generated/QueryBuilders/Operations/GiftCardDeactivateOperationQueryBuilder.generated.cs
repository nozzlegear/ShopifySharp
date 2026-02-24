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
    public sealed class GiftCardDeactivateOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardDeactivatePayload, GiftCardDeactivateOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardDeactivatePayload>, IHasArguments<GiftCardDeactivateArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public GiftCardDeactivateArgumentsBuilder Arguments { get; }
        protected override GiftCardDeactivateOperationQueryBuilder Self => this;

        public GiftCardDeactivateOperationQueryBuilder() : this("giftCardDeactivate")
        {
        }

        public GiftCardDeactivateOperationQueryBuilder(string name) : base(new Query<GiftCardDeactivatePayload>(name))
        {
            Arguments = new GiftCardDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardDeactivateOperationQueryBuilder(IQuery<GiftCardDeactivatePayload> query) : base(query)
        {
            Arguments = new GiftCardDeactivateArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardDeactivateOperationQueryBuilder SetArguments(Action<GiftCardDeactivateArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public GiftCardDeactivateOperationQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardDeactivateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardDeactivateUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardDeactivateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardDeactivateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardDeactivateUserError>(query);
            return this;
        }
    }
}