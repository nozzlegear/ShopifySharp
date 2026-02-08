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
    public sealed class DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticFreeShippingUpdatePayload, DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder>
    {
        protected override DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder Self => this;

        public DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder() : this("discountAutomaticFreeShippingUpdatePayload")
        {
        }

        public DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder(string name) : base(new Query<DiscountAutomaticFreeShippingUpdatePayload>(name))
        {
        }

        public DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder(IQuery<DiscountAutomaticFreeShippingUpdatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder AutomaticDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticNode>("automaticDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticNode>(query);
            return this;
        }

        public DiscountAutomaticFreeShippingUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}