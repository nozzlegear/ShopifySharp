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
    public sealed class GiftCardCreateOperationQueryBuilder : FieldsQueryBuilderBase<GiftCardCreatePayload, GiftCardCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<GiftCardCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public GiftCardCreateArgumentsBuilder Arguments { get; }
        protected override GiftCardCreateOperationQueryBuilder Self => this;

        public GiftCardCreateOperationQueryBuilder() : this("giftCardCreate")
        {
        }

        public GiftCardCreateOperationQueryBuilder(string name) : base(new Query<GiftCardCreatePayload>(name))
        {
            Arguments = new GiftCardCreateArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardCreateOperationQueryBuilder(IQuery<GiftCardCreatePayload> query) : base(query)
        {
            Arguments = new GiftCardCreateArgumentsBuilder(base.InnerQuery);
        }

        public GiftCardCreateOperationQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardCreateOperationQueryBuilder GiftCardCode()
        {
            base.InnerQuery.AddField("giftCardCode");
            return this;
        }

        public GiftCardCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardUserError>(query);
            return this;
        }
    }
}