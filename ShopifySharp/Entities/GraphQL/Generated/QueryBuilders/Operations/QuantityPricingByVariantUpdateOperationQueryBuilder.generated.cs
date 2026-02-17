#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
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

        public QuantityPricingByVariantUpdateOperationQueryBuilder ProductVariants(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder> build)
        {
            var query = new Query<ProductVariant>("productVariants");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductVariantQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductVariant>(query);
            return this;
        }

        public QuantityPricingByVariantUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPricingByVariantUserErrorQueryBuilder> build)
        {
            var query = new Query<QuantityPricingByVariantUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.QuantityPricingByVariantUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<QuantityPricingByVariantUserError>(query);
            return this;
        }
    }
}