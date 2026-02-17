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
    public sealed class CatalogCsvOperationQueryBuilder : FieldsQueryBuilderBase<CatalogCsvOperation, CatalogCsvOperationQueryBuilder>
    {
        protected override CatalogCsvOperationQueryBuilder Self => this;

        public CatalogCsvOperationQueryBuilder() : this("catalogCsvOperation")
        {
        }

        public CatalogCsvOperationQueryBuilder(string name) : base(new Query<CatalogCsvOperation>(name))
        {
        }

        public CatalogCsvOperationQueryBuilder(IQuery<CatalogCsvOperation> query) : base(query)
        {
        }

        public CatalogCsvOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CatalogCsvOperationQueryBuilder ProcessedRowCount()
        {
            base.InnerQuery.AddField("processedRowCount");
            return this;
        }

        public CatalogCsvOperationQueryBuilder RowCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RowCountQueryBuilder> build)
        {
            var query = new Query<RowCount>("rowCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RowCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RowCount>(query);
            return this;
        }

        public CatalogCsvOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}