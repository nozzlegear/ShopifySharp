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
    public sealed class DiscountShippingDestinationSelectionQueryBuilder : FieldsQueryBuilderBase<DiscountShippingDestinationSelection, DiscountShippingDestinationSelectionQueryBuilder>
    {
        protected override DiscountShippingDestinationSelectionQueryBuilder Self => this;

        public DiscountShippingDestinationSelectionQueryBuilder() : this("discountShippingDestinationSelection")
        {
        }

        public DiscountShippingDestinationSelectionQueryBuilder(string name) : base(new Query<DiscountShippingDestinationSelection>(name))
        {
        }

        public DiscountShippingDestinationSelectionQueryBuilder(IQuery<DiscountShippingDestinationSelection> query) : base(query)
        {
        }

        public DiscountShippingDestinationSelectionQueryBuilder DiscountShippingDestinationSelection(Action<DiscountShippingDestinationSelectionUnionCasesBuilder> build)
        {
            var query = new Query<DiscountShippingDestinationSelection>("discountShippingDestinationSelection");
            var unionBuilder = new DiscountShippingDestinationSelectionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}