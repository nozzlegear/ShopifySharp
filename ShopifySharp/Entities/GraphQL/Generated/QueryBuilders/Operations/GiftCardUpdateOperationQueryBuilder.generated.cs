#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class GiftCardUpdateOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardUpdatePayload, GiftCardUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public GiftCardUpdateArgumentsBuilder Arguments { get; }
        protected override GiftCardUpdateOperationQueryBuilder Self => this;

        public GiftCardUpdateOperationQueryBuilder() : this("giftCardUpdate")
        {
        }

        public GiftCardUpdateOperationQueryBuilder(string name) : base(new Query<GiftCardUpdatePayload>(name))
        {
            Arguments = new GiftCardUpdateArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardUpdateOperationQueryBuilder(IQuery<GiftCardUpdatePayload> query) : base(query)
        {
            Arguments = new GiftCardUpdateArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardUpdateOperationQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}