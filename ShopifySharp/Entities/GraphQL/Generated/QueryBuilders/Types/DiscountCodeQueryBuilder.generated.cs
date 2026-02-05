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
    public sealed class DiscountCodeQueryBuilder : FieldsQueryBuilderBase<DiscountCode, DiscountCodeQueryBuilder>
    {
        protected override DiscountCodeQueryBuilder Self => this;

        public DiscountCodeQueryBuilder() : this("discountCode")
        {
        }

        public DiscountCodeQueryBuilder(string name) : base(new Query<DiscountCode>(name))
        {
        }

        public DiscountCodeQueryBuilder(IQuery<DiscountCode> query) : base(query)
        {
        }

        public DiscountCodeQueryBuilder DiscountCode(Action<DiscountCodeUnionCasesBuilder> build)
        {
            var query = new Query<DiscountCode>("discountCode");
            var unionBuilder = new DiscountCodeUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}