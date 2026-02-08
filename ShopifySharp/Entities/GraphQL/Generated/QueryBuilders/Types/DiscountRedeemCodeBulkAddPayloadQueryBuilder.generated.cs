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
    public sealed class DiscountRedeemCodeBulkAddPayloadQueryBuilder : FieldsQueryBuilderBase<DiscountRedeemCodeBulkAddPayload, DiscountRedeemCodeBulkAddPayloadQueryBuilder>
    {
        protected override DiscountRedeemCodeBulkAddPayloadQueryBuilder Self => this;

        public DiscountRedeemCodeBulkAddPayloadQueryBuilder() : this("discountRedeemCodeBulkAddPayload")
        {
        }

        public DiscountRedeemCodeBulkAddPayloadQueryBuilder(string name) : base(new Query<DiscountRedeemCodeBulkAddPayload>(name))
        {
        }

        public DiscountRedeemCodeBulkAddPayloadQueryBuilder(IQuery<DiscountRedeemCodeBulkAddPayload> query) : base(query)
        {
        }

        public DiscountRedeemCodeBulkAddPayloadQueryBuilder BulkCreation(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationQueryBuilder> build)
        {
            var query = new Query<DiscountRedeemCodeBulkCreation>("bulkCreation");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountRedeemCodeBulkCreationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountRedeemCodeBulkCreation>(query);
            return this;
        }

        public DiscountRedeemCodeBulkAddPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}