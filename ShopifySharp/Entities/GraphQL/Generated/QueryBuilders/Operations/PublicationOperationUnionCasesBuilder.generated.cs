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
    public sealed class PublicationOperationUnionCasesBuilder : UnionCasesBuilderBase<PublicationOperation, PublicationOperationUnionCasesBuilder>
    {
        protected override PublicationOperationUnionCasesBuilder Self => this;

        public PublicationOperationUnionCasesBuilder(string fieldName = "operation") : this(new Query<PublicationOperation>(fieldName))
        {
        }

        public PublicationOperationUnionCasesBuilder(IQuery<PublicationOperation> query) : base(query)
        {
        }

        public PublicationOperationUnionCasesBuilder OnAddAllProductsOperation(Action<AddAllProductsOperationQueryBuilder> build)
        {
            var query = new Query<AddAllProductsOperation>("... on AddAllProductsOperation");
            var queryBuilder = new AddAllProductsOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PublicationOperationUnionCasesBuilder OnCatalogCsvOperation(Action<CatalogCsvOperationQueryBuilder> build)
        {
            var query = new Query<CatalogCsvOperation>("... on CatalogCsvOperation");
            var queryBuilder = new CatalogCsvOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public PublicationOperationUnionCasesBuilder OnPublicationResourceOperation(Action<PublicationResourceOperationQueryBuilder> build)
        {
            var query = new Query<PublicationResourceOperation>("... on PublicationResourceOperation");
            var queryBuilder = new PublicationResourceOperationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}