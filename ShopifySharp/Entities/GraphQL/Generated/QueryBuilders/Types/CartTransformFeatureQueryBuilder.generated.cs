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
    public sealed class CartTransformFeatureQueryBuilder : FieldsQueryBuilderBase<CartTransformFeature, CartTransformFeatureQueryBuilder>
    {
        protected override CartTransformFeatureQueryBuilder Self => this;

        public CartTransformFeatureQueryBuilder() : this("cartTransformFeature")
        {
        }

        public CartTransformFeatureQueryBuilder(string name) : base(new Query<CartTransformFeature>(name))
        {
        }

        public CartTransformFeatureQueryBuilder(IQuery<CartTransformFeature> query) : base(query)
        {
        }

        public CartTransformFeatureQueryBuilder EligibleOperations(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformEligibleOperationsQueryBuilder> build)
        {
            var query = new Query<CartTransformEligibleOperations>("eligibleOperations");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CartTransformEligibleOperationsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformEligibleOperations>(query);
            return this;
        }
    }
}