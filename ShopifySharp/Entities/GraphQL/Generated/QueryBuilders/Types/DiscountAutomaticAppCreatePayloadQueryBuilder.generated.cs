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
    public sealed class DiscountAutomaticAppCreatePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticAppCreatePayload, DiscountAutomaticAppCreatePayloadQueryBuilder>
    {
        protected override DiscountAutomaticAppCreatePayloadQueryBuilder Self => this;

        public DiscountAutomaticAppCreatePayloadQueryBuilder() : this("discountAutomaticAppCreatePayload")
        {
        }

        public DiscountAutomaticAppCreatePayloadQueryBuilder(string name) : base(new Query<DiscountAutomaticAppCreatePayload>(name))
        {
        }

        public DiscountAutomaticAppCreatePayloadQueryBuilder(IQuery<DiscountAutomaticAppCreatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticAppCreatePayloadQueryBuilder AutomaticAppDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("automaticAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticApp>(query);
            return this;
        }

        public DiscountAutomaticAppCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}