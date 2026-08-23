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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class DiscountCustomerSelectionUnknownQueryBuilder : FieldsQueryBuilderBase<DiscountCustomerSelectionUnknown, DiscountCustomerSelectionUnknownQueryBuilder>
    {
        protected override DiscountCustomerSelectionUnknownQueryBuilder Self => this;

        public DiscountCustomerSelectionUnknownQueryBuilder() : this("discountCustomerSelectionUnknown")
        {
        }

        public DiscountCustomerSelectionUnknownQueryBuilder(string name) : base(new Query<DiscountCustomerSelectionUnknown>(name))
        {
        }

        public DiscountCustomerSelectionUnknownQueryBuilder(IQuery<DiscountCustomerSelectionUnknown> query) : base(query)
        {
        }

        public DiscountCustomerSelectionUnknownQueryBuilder CustomerSelectionType()
        {
            base.InnerQuery.AddField("customerSelectionType");
            return this;
        }
    }
}