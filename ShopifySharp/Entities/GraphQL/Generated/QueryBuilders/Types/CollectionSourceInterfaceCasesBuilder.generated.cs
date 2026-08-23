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
    public sealed class CollectionSourceInterfaceCasesBuilder : InterfaceCasesBuilderBase<ICollectionSource, CollectionSourceInterfaceCasesBuilder>
    {
        protected override CollectionSourceInterfaceCasesBuilder Self => this;

        public CollectionSourceInterfaceCasesBuilder(string fieldName = "collectionSource") : this(new Query<ICollectionSource>(fieldName))
        {
        }

        public CollectionSourceInterfaceCasesBuilder(IQuery<ICollectionSource> query) : base(query)
        {
        }

        public CollectionSourceInterfaceCasesBuilder OnCollectionConditionsSource(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionConditionsSource>("... on CollectionConditionsSource");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionConditionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public CollectionSourceInterfaceCasesBuilder OnCollectionSubCollectionsSource(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionsSourceQueryBuilder> build)
        {
            var query = new Query<CollectionSubCollectionsSource>("... on CollectionSubCollectionsSource");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CollectionSubCollectionsSourceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}