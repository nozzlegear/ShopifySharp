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
    public sealed class CatalogOperationsOperationQueryBuilder : FieldsQueryBuilderBase<IResourceOperation, CatalogOperationsOperationQueryBuilder>, IGraphOperationQueryBuilder<IResourceOperation>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override CatalogOperationsOperationQueryBuilder Self => this;

        public CatalogOperationsOperationQueryBuilder() : this("catalogOperations")
        {
        }

        public CatalogOperationsOperationQueryBuilder(string name) : base(new Query<IResourceOperation>(name))
        {
        }

        public CatalogOperationsOperationQueryBuilder(IQuery<IResourceOperation> query) : base(query)
        {
        }

        public CatalogOperationsOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CatalogOperationsOperationQueryBuilder ProcessedRowCount()
        {
            base.InnerQuery.AddField("processedRowCount");
            return this;
        }

        public CatalogOperationsOperationQueryBuilder RowCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RowCountQueryBuilder> build)
        {
            var query = new Query<RowCount>("rowCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RowCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RowCount>(query);
            return this;
        }

        public CatalogOperationsOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CatalogOperationsOperationQueryBuilder OnAddAllProductsOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AddAllProductsOperationQueryBuilder> build)
        {
            var query = new Query<AddAllProductsOperation>("... on AddAllProductsOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AddAllProductsOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CatalogOperationsOperationQueryBuilder OnCatalogCsvOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogCsvOperationQueryBuilder> build)
        {
            var query = new Query<CatalogCsvOperation>("... on CatalogCsvOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogCsvOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public CatalogOperationsOperationQueryBuilder OnPublicationResourceOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationResourceOperationQueryBuilder> build)
        {
            var query = new Query<PublicationResourceOperation>("... on PublicationResourceOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}