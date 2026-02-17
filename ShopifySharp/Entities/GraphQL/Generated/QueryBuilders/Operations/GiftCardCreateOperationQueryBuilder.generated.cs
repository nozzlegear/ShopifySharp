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

        public GiftCardCreateOperationQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardCreateOperationQueryBuilder GiftCardCode()
        {
            base.InnerQuery.AddField("giftCardCode");
            return this;
        }

        public GiftCardCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.GiftCardUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardUserError>(query);
            return this;
        }
    }
}