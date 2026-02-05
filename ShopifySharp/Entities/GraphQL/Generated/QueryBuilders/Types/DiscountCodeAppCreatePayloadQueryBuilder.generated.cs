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
    public sealed class DiscountCodeAppCreatePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountCodeAppCreatePayload, DiscountCodeAppCreatePayloadQueryBuilder>
    {
        protected override DiscountCodeAppCreatePayloadQueryBuilder Self => this;

        public DiscountCodeAppCreatePayloadQueryBuilder() : this("discountCodeAppCreatePayload")
        {
        }

        public DiscountCodeAppCreatePayloadQueryBuilder(string name) : base(new Query<DiscountCodeAppCreatePayload>(name))
        {
        }

        public DiscountCodeAppCreatePayloadQueryBuilder(IQuery<DiscountCodeAppCreatePayload> query) : base(query)
        {
        }

        public DiscountCodeAppCreatePayloadQueryBuilder CodeAppDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("codeAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeApp>(query);
            return this;
        }

        public DiscountCodeAppCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}