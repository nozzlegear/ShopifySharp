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
    public sealed class DiscountItemsQueryBuilder : FieldsQueryBuilderBase<DiscountItems, DiscountItemsQueryBuilder>
    {
        protected override DiscountItemsQueryBuilder Self => this;

        public DiscountItemsQueryBuilder() : this("discountItems")
        {
        }

        public DiscountItemsQueryBuilder(string name) : base(new Query<DiscountItems>(name))
        {
        }

        public DiscountItemsQueryBuilder(IQuery<DiscountItems> query) : base(query)
        {
        }

        public DiscountItemsQueryBuilder DiscountItems(Action<DiscountItemsUnionCasesBuilder> build)
        {
            var query = new Query<DiscountItems>("discountItems");
            var unionBuilder = new DiscountItemsUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}