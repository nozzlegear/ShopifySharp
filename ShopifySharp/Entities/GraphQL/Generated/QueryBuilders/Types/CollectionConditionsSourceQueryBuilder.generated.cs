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
    public sealed class CollectionConditionsSourceQueryBuilder : FieldsQueryBuilderBase<CollectionConditionsSource, CollectionConditionsSourceQueryBuilder>
    {
        protected override CollectionConditionsSourceQueryBuilder Self => this;

        public CollectionConditionsSourceQueryBuilder() : this("collectionConditionsSource")
        {
        }

        public CollectionConditionsSourceQueryBuilder(string name) : base(new Query<CollectionConditionsSource>(name))
        {
        }

        public CollectionConditionsSourceQueryBuilder(IQuery<CollectionConditionsSource> query) : base(query)
        {
        }

        public CollectionConditionsSourceQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public CollectionConditionsSourceQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public CollectionConditionsSourceQueryBuilder Exclusion(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionQueryBuilder> build)
        {
            var query = new Query<CollectionSourceExclusion>("exclusion");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceExclusionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionSourceExclusion>(query);
            return this;
        }

        public CollectionConditionsSourceQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CollectionConditionsSourceQueryBuilder Inclusion(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionQueryBuilder> build)
        {
            var query = new Query<CollectionSourceInclusion>("inclusion");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSourceInclusionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CollectionSourceInclusion>(query);
            return this;
        }

        public CollectionConditionsSourceQueryBuilder Products(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder> build)
        {
            var query = new Query<ProductConnection>("products");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ProductConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ProductConnection>(query);
            return this;
        }

        public CollectionConditionsSourceQueryBuilder Shareable()
        {
            base.InnerQuery.AddField("shareable");
            return this;
        }

        public CollectionConditionsSourceQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public CollectionConditionsSourceQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}