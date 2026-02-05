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
    public sealed class DiscountCustomerSelectionQueryBuilder : FieldsQueryBuilderBase<DiscountCustomerSelection, DiscountCustomerSelectionQueryBuilder>
    {
        protected override DiscountCustomerSelectionQueryBuilder Self => this;

        public DiscountCustomerSelectionQueryBuilder() : this("discountCustomerSelection")
        {
        }

        public DiscountCustomerSelectionQueryBuilder(string name) : base(new Query<DiscountCustomerSelection>(name))
        {
        }

        public DiscountCustomerSelectionQueryBuilder(IQuery<DiscountCustomerSelection> query) : base(query)
        {
        }

        public DiscountCustomerSelectionQueryBuilder DiscountCustomerSelection(Action<DiscountCustomerSelectionUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCustomerSelection>("discountCustomerSelection");
            var unionBuilder = new DiscountCustomerSelectionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}