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
    public sealed class DiscountAutomaticQueryBuilder : FieldsQueryBuilderBase<DiscountAutomatic, DiscountAutomaticQueryBuilder>
    {
        protected override DiscountAutomaticQueryBuilder Self => this;

        public DiscountAutomaticQueryBuilder() : this("discountAutomatic")
        {
        }

        public DiscountAutomaticQueryBuilder(string name) : base(new Query<DiscountAutomatic>(name))
        {
        }

        public DiscountAutomaticQueryBuilder(IQuery<DiscountAutomatic> query) : base(query)
        {
        }

        public DiscountAutomaticQueryBuilder DiscountAutomatic(Action<DiscountAutomaticUnionCasesBuilder> build)
        {
            var query = new Query<DiscountAutomatic>("discountAutomatic");
            var unionBuilder = new DiscountAutomaticUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}