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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class QuantityPricingByVariantUpdateOperationQueryBuilder : FieldsQueryBuilderBase<QuantityPricingByVariantUpdatePayload, QuantityPricingByVariantUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<QuantityPricingByVariantUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public QuantityPricingByVariantUpdateArgumentsBuilder Arguments { get; }
        protected override QuantityPricingByVariantUpdateOperationQueryBuilder Self => this;

        public QuantityPricingByVariantUpdateOperationQueryBuilder() : this("quantityPricingByVariantUpdate")
        {
        }

        public QuantityPricingByVariantUpdateOperationQueryBuilder(string name) : base(new Query<QuantityPricingByVariantUpdatePayload>(name))
        {
            Arguments = new QuantityPricingByVariantUpdateArgumentsBuilder(base.InnerQuery);
        }

        public QuantityPricingByVariantUpdateOperationQueryBuilder(IQuery<QuantityPricingByVariantUpdatePayload> query) : base(query)
        {
            Arguments = new QuantityPricingByVariantUpdateArgumentsBuilder(base.InnerQuery);
        }

        public QuantityPricingByVariantUpdateOperationQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public QuantityPricingByVariantUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityPricingByVariantUserErrorQueryBuilder> build)
        {
            var query = new Query<QuantityPricingByVariantUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.QuantityPricingByVariantUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPricingByVariantUserError>(query);
            return this;
        }
    }
}