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
    public sealed class DiscountContextQueryBuilder : FieldsQueryBuilderBase<DiscountContext, DiscountContextQueryBuilder>
    {
        protected override DiscountContextQueryBuilder Self => this;

        public DiscountContextQueryBuilder() : this("discountContext")
        {
        }

        public DiscountContextQueryBuilder(string name) : base(new Query<DiscountContext>(name))
        {
        }

        public DiscountContextQueryBuilder(IQuery<DiscountContext> query) : base(query)
        {
        }

        public DiscountContextQueryBuilder DiscountContext(Action<DiscountContextUnionCasesBuilder> build)
        {
            var query = new Query<DiscountContext>("discountContext");
            var unionBuilder = new DiscountContextUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}