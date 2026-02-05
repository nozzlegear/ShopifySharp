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
    public sealed class DiscountAutomaticDeletePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountAutomaticDeletePayload, DiscountAutomaticDeletePayloadQueryBuilder>
    {
        protected override DiscountAutomaticDeletePayloadQueryBuilder Self => this;

        public DiscountAutomaticDeletePayloadQueryBuilder() : this("discountAutomaticDeletePayload")
        {
        }

        public DiscountAutomaticDeletePayloadQueryBuilder(string name) : base(new Query<DiscountAutomaticDeletePayload>(name))
        {
        }

        public DiscountAutomaticDeletePayloadQueryBuilder(IQuery<DiscountAutomaticDeletePayload> query) : base(query)
        {
        }

        public DiscountAutomaticDeletePayloadQueryBuilder DeletedAutomaticDiscountId()
        {
            base.InnerQuery.AddField("deletedAutomaticDiscountId");
            return this;
        }

        public DiscountAutomaticDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}