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
    public sealed class QueryRootAutomaticDiscountQueryBuilder : FieldsQueryBuilderBase<DiscountAutomatic, QueryRootAutomaticDiscountQueryBuilder>, IHasArguments<QueryRootAutomaticDiscountArgumentsBuilder>
    {
        public QueryRootAutomaticDiscountArgumentsBuilder Arguments { get; }
        protected override QueryRootAutomaticDiscountQueryBuilder Self => this;

        public QueryRootAutomaticDiscountQueryBuilder(string name) : base(new Query<DiscountAutomatic>(name))
        {
            Arguments = new QueryRootAutomaticDiscountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAutomaticDiscountQueryBuilder(IQuery<DiscountAutomatic> query) : base(query)
        {
            Arguments = new QueryRootAutomaticDiscountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAutomaticDiscountQueryBuilder SetArguments(Action<QueryRootAutomaticDiscountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootAutomaticDiscountQueryBuilder DiscountAutomatic(Action<DiscountAutomaticUnionCasesBuilder> build)
        {
            var query = new Query<DiscountAutomatic>("discountAutomatic");
            var unionBuilder = new DiscountAutomaticUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}