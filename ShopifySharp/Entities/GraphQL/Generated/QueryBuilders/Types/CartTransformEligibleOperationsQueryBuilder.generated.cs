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
    public sealed class CartTransformEligibleOperationsQueryBuilder : FieldsQueryBuilderBase<CartTransformEligibleOperations, CartTransformEligibleOperationsQueryBuilder>
    {
        protected override CartTransformEligibleOperationsQueryBuilder Self => this;

        public CartTransformEligibleOperationsQueryBuilder() : this("cartTransformEligibleOperations")
        {
        }

        public CartTransformEligibleOperationsQueryBuilder(string name) : base(new Query<CartTransformEligibleOperations>(name))
        {
        }

        public CartTransformEligibleOperationsQueryBuilder(IQuery<CartTransformEligibleOperations> query) : base(query)
        {
        }

        public CartTransformEligibleOperationsQueryBuilder ExpandOperation()
        {
            base.InnerQuery.AddField("expandOperation");
            return this;
        }

        public CartTransformEligibleOperationsQueryBuilder MergeOperation()
        {
            base.InnerQuery.AddField("mergeOperation");
            return this;
        }

        public CartTransformEligibleOperationsQueryBuilder UpdateOperation()
        {
            base.InnerQuery.AddField("updateOperation");
            return this;
        }
    }
}