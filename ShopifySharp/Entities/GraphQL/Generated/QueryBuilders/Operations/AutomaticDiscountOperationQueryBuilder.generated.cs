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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    [Obsolete("Use `automaticDiscountNode` instead.")]
    public sealed class AutomaticDiscountOperationQueryBuilder : FieldsQueryBuilderBase<DiscountAutomatic, AutomaticDiscountOperationQueryBuilder>, IGraphOperationQueryBuilder<DiscountAutomatic>, IHasArguments<AutomaticDiscountArgumentsBuilder>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AutomaticDiscountArgumentsBuilder Arguments { get; }
        protected override AutomaticDiscountOperationQueryBuilder Self => this;

        public AutomaticDiscountOperationQueryBuilder() : this("automaticDiscount")
        {
        }

        public AutomaticDiscountOperationQueryBuilder(string name) : base(new Query<DiscountAutomatic>(name))
        {
            Arguments = new AutomaticDiscountArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountOperationQueryBuilder(IQuery<DiscountAutomatic> query) : base(query)
        {
            Arguments = new AutomaticDiscountArgumentsBuilder(base.InnerQuery);
        }

        public AutomaticDiscountOperationQueryBuilder SetArguments(Action<AutomaticDiscountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AutomaticDiscountOperationQueryBuilder OnDiscountAutomaticApp(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticApp>("... on DiscountAutomaticApp");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticAppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public AutomaticDiscountOperationQueryBuilder OnDiscountAutomaticBasic(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBasicQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBasic>("... on DiscountAutomaticBasic");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBasicQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public AutomaticDiscountOperationQueryBuilder OnDiscountAutomaticBxgy(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticBxgy>("... on DiscountAutomaticBxgy");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticBxgyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public AutomaticDiscountOperationQueryBuilder OnDiscountAutomaticFreeShipping(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticFreeShippingQueryBuilder> build)
        {
            var query = new Query<DiscountAutomaticFreeShipping>("... on DiscountAutomaticFreeShipping");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountAutomaticFreeShippingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}