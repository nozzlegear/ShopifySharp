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
    public sealed class CollectionExclusionProductSelectionQueryBuilder : FieldsQueryBuilderBase<CollectionExclusionProductSelection, CollectionExclusionProductSelectionQueryBuilder>
    {
        protected override CollectionExclusionProductSelectionQueryBuilder Self => this;

        public CollectionExclusionProductSelectionQueryBuilder() : this("collectionExclusionProductSelection")
        {
        }

        public CollectionExclusionProductSelectionQueryBuilder(string name) : base(new Query<CollectionExclusionProductSelection>(name))
        {
        }

        public CollectionExclusionProductSelectionQueryBuilder(IQuery<CollectionExclusionProductSelection> query) : base(query)
        {
        }

        public CollectionExclusionProductSelectionQueryBuilder Product(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder> build)
        {
            var query = new Query<Product>("product");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Product>(query);
            return this;
        }
    }
}