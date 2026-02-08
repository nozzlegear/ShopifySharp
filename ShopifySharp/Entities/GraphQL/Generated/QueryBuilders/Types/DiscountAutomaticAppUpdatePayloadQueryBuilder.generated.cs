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
    public sealed class DiscountAutomaticAppUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticAppUpdatePayload, DiscountAutomaticAppUpdatePayloadQueryBuilder>
    {
        protected override DiscountAutomaticAppUpdatePayloadQueryBuilder Self => this;

        public DiscountAutomaticAppUpdatePayloadQueryBuilder() : this("discountAutomaticAppUpdatePayload")
        {
        }

        public DiscountAutomaticAppUpdatePayloadQueryBuilder(string name) : base(new Query<DiscountAutomaticAppUpdatePayload>(name))
        {
        }

        public DiscountAutomaticAppUpdatePayloadQueryBuilder(IQuery<DiscountAutomaticAppUpdatePayload> query) : base(query)
        {
        }

        public DiscountAutomaticAppUpdatePayloadQueryBuilder AutomaticAppDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("automaticAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountAutomaticApp>(query);
            return this;
        }

        public DiscountAutomaticAppUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}