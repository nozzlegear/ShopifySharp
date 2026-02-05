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
    public sealed class DiscountCodeAppUpdatePayloadQueryBuilder : FieldsQueryBuilderBase<DiscountCodeAppUpdatePayload, DiscountCodeAppUpdatePayloadQueryBuilder>
    {
        protected override DiscountCodeAppUpdatePayloadQueryBuilder Self => this;

        public DiscountCodeAppUpdatePayloadQueryBuilder() : this("discountCodeAppUpdatePayload")
        {
        }

        public DiscountCodeAppUpdatePayloadQueryBuilder(string name) : base(new Query<DiscountCodeAppUpdatePayload>(name))
        {
        }

        public DiscountCodeAppUpdatePayloadQueryBuilder(IQuery<DiscountCodeAppUpdatePayload> query) : base(query)
        {
        }

        public DiscountCodeAppUpdatePayloadQueryBuilder CodeAppDiscount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeAppQueryBuilder> build)
        {
            var query = new Query<DiscountCodeApp>("codeAppDiscount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountCodeAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeApp>(query);
            return this;
        }

        public DiscountCodeAppUpdatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder> build)
        {
            var query = new Query<DiscountUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DiscountUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountUserError>(query);
            return this;
        }
    }
}