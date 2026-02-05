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
    public sealed class DiscountCodeFreeShippingCreatePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountCodeFreeShippingCreatePayload, DiscountCodeFreeShippingCreatePayloadQueryBuilder>
    {
        protected override DiscountCodeFreeShippingCreatePayloadQueryBuilder Self => this;

        public DiscountCodeFreeShippingCreatePayloadQueryBuilder() : this("discountCodeFreeShippingCreatePayload")
        {
        }

        public DiscountCodeFreeShippingCreatePayloadQueryBuilder(string name) : base(new Query<DiscountCodeFreeShippingCreatePayload>(name))
        {
        }

        public DiscountCodeFreeShippingCreatePayloadQueryBuilder(IQuery<DiscountCodeFreeShippingCreatePayload> query) : base(query)
        {
        }

        public DiscountCodeFreeShippingCreatePayloadQueryBuilder CodeDiscountNode(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("codeDiscountNode");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeFreeShippingCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}