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
    public sealed class GiftCardDeactivatePayloadQueryBuilder : FieldsQueryBuilderBase<GiftCardDeactivatePayload, GiftCardDeactivatePayloadQueryBuilder>
    {
        protected override GiftCardDeactivatePayloadQueryBuilder Self => this;

        public GiftCardDeactivatePayloadQueryBuilder() : this("giftCardDeactivatePayload")
        {
        }

        public GiftCardDeactivatePayloadQueryBuilder(string name) : base(new Query<GiftCardDeactivatePayload>(name))
        {
        }

        public GiftCardDeactivatePayloadQueryBuilder(IQuery<GiftCardDeactivatePayload> query) : base(query)
        {
        }

        public GiftCardDeactivatePayloadQueryBuilder GiftCard(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder> build)
        {
            var query = new Query<GiftCard>("giftCard");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCard>(query);
            return this;
        }

        public GiftCardDeactivatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardDeactivateUserErrorQueryBuilder> build)
        {
            var query = new Query<GiftCardDeactivateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.GiftCardDeactivateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<GiftCardDeactivateUserError>(query);
            return this;
        }
    }
}