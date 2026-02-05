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
    public sealed class AddAllProductsOperationQueryBuilder : FieldsQueryBuilderBase<AddAllProductsOperation, AddAllProductsOperationQueryBuilder>
    {
        protected override AddAllProductsOperationQueryBuilder Self => this;

        public AddAllProductsOperationQueryBuilder() : this("addAllProductsOperation")
        {
        }

        public AddAllProductsOperationQueryBuilder(string name) : base(new Query<AddAllProductsOperation>(name))
        {
        }

        public AddAllProductsOperationQueryBuilder(IQuery<AddAllProductsOperation> query) : base(query)
        {
        }

        public AddAllProductsOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public AddAllProductsOperationQueryBuilder ProcessedRowCount()
        {
            base.InnerQuery.AddField("processedRowCount");
            return this;
        }

        public AddAllProductsOperationQueryBuilder RowCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RowCountQueryBuilder> build)
        {
            var query = new Query<RowCount>("rowCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RowCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RowCount>(query);
            return this;
        }

        public AddAllProductsOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}