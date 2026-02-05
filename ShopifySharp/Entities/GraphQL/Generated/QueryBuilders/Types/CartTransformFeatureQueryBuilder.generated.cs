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

        public CartTransformFeatureQueryBuilder EligibleOperations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformEligibleOperationsQueryBuilder> build)
        {
            var query = new Query<CartTransformEligibleOperations>("eligibleOperations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CartTransformEligibleOperationsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CartTransformEligibleOperations>(query);
            return this;
        }
    }
}