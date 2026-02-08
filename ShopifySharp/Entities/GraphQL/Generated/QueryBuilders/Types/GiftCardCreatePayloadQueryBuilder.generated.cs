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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class GiftCardCreatePayloadQueryBuilder : FieldsQueryBuilderBase<GiftCardCreatePayload, GiftCardCreatePayloadQueryBuilder>
    {
        protected override GiftCardCreatePayloadQueryBuilder Self => this;

        public GiftCardCreatePayloadQueryBuilder() : this("giftCardCreatePayload")
        {
        }

        public GiftCardCreatePayloadQueryBuilder(string name) : base(new Query<GiftCardCreatePayload>(name))
        {
        }

        public GiftCardCreatePayloadQueryBuilder(IQuery<GiftCardCreatePayload> query) : base(query)
        {
        }

        public GiftCardCreatePayloadQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardCreatePayloadQueryBuilder GiftCardCode()
        {
            base.InnerQuery.AddField("giftCardCode");
            return this;
        }

        public GiftCardCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardUserError>(query);
            return this;
        }
    }
}