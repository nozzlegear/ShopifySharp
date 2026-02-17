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
    public sealed class DiscountPercentageQueryBuilder : FieldsQueryBuilderBase<DiscountPercentage, DiscountPercentageQueryBuilder>
    {
        protected override DiscountPercentageQueryBuilder Self => this;

        public DiscountPercentageQueryBuilder() : this("discountPercentage")
        {
        }

        public DiscountPercentageQueryBuilder(string name) : base(new Query<DiscountPercentage>(name))
        {
        }

        public DiscountPercentageQueryBuilder(IQuery<DiscountPercentage> query) : base(query)
        {
        }

        public DiscountPercentageQueryBuilder Percentage()
        {
            base.InnerQuery.AddField("percentage");
            return this;
        }
    }
}