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
    public sealed class DiscountCodeDeletePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountCodeDeletePayload, DiscountCodeDeletePayloadQueryBuilder>
    {
        protected override DiscountCodeDeletePayloadQueryBuilder Self => this;

        public DiscountCodeDeletePayloadQueryBuilder() : this("discountCodeDeletePayload")
        {
        }

        public DiscountCodeDeletePayloadQueryBuilder(string name) : base(new Query<DiscountCodeDeletePayload>(name))
        {
        }

        public DiscountCodeDeletePayloadQueryBuilder(IQuery<DiscountCodeDeletePayload> query) : base(query)
        {
        }

        public DiscountCodeDeletePayloadQueryBuilder DeletedCodeDiscountId()
        {
            base.InnerQuery.AddField("deletedCodeDiscountId");
            return this;
        }

        public DiscountCodeDeletePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}