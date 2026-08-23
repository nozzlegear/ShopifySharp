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
    public sealed class ResourceOperationQueryBuilder : FieldsQueryBuilderBase<IResourceOperation, ResourceOperationQueryBuilder>
    {
        protected override ResourceOperationQueryBuilder Self => this;

        public ResourceOperationQueryBuilder() : this("resourceOperation")
        {
        }

        public ResourceOperationQueryBuilder(string name) : base(new Query<IResourceOperation>(name))
        {
        }

        public ResourceOperationQueryBuilder(IQuery<IResourceOperation> query) : base(query)
        {
        }

        public ResourceOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ResourceOperationQueryBuilder ProcessedRowCount()
        {
            base.InnerQuery.AddField("processedRowCount");
            return this;
        }

        public ResourceOperationQueryBuilder RowCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RowCountQueryBuilder> build)
        {
            var query = new Query<RowCount>("rowCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RowCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RowCount>(query);
            return this;
        }

        public ResourceOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ResourceOperationQueryBuilder OnAddAllProductsOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AddAllProductsOperationQueryBuilder> build)
        {
            var query = new Query<AddAllProductsOperation>("... on AddAllProductsOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AddAllProductsOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public ResourceOperationQueryBuilder OnCatalogCsvOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogCsvOperationQueryBuilder> build)
        {
            var query = new Query<CatalogCsvOperation>("... on CatalogCsvOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogCsvOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public ResourceOperationQueryBuilder OnPublicationResourceOperation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PublicationResourceOperationQueryBuilder> build)
        {
            var query = new Query<PublicationResourceOperation>("... on PublicationResourceOperation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PublicationResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public ResourceOperationQueryBuilder ResourceOperation(Action<ResourceOperationInterfaceCasesBuilder> build)
        {
            var query = new Query<IResourceOperation>("resourceOperation");
            var unionBuilder = new ResourceOperationInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}