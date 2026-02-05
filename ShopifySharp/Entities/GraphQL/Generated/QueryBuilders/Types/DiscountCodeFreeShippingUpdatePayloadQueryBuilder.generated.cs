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
    public sealed class DiscountCodeFreeShippingUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountCodeFreeShippingUpdatePayload, DiscountCodeFreeShippingUpdatePayloadQueryBuilder>
    {
        protected override DiscountCodeFreeShippingUpdatePayloadQueryBuilder Self => this;

        public DiscountCodeFreeShippingUpdatePayloadQueryBuilder() : this("discountCodeFreeShippingUpdatePayload")
        {
        }

        public DiscountCodeFreeShippingUpdatePayloadQueryBuilder(string name) : base(new Query<DiscountCodeFreeShippingUpdatePayload>(name))
        {
        }

        public DiscountCodeFreeShippingUpdatePayloadQueryBuilder(IQuery<DiscountCodeFreeShippingUpdatePayload> query) : base(query)
        {
        }

        public DiscountCodeFreeShippingUpdatePayloadQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeFreeShippingUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}