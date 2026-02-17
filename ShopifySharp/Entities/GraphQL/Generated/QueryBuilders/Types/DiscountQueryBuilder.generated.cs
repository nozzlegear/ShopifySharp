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
    public sealed class DiscountQueryBuilder : FieldsQueryBuilderBase<Discount, DiscountQueryBuilder>
    {
        protected override DiscountQueryBuilder Self => this;

        public DiscountQueryBuilder() : this("discount")
        {
        }

        public DiscountQueryBuilder(string name) : base(new Query<Discount>(name))
        {
        }

        public DiscountQueryBuilder(IQuery<Discount> query) : base(query)
        {
        }

        public DiscountQueryBuilder Discount(Action<DiscountUnionCasesBuilder> build)
        {
            var query = new Query<Discount>("discount");
            var unionBuilder = new DiscountUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}