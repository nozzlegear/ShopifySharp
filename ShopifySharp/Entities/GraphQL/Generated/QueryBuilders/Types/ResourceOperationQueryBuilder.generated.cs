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

        public ResourceOperationQueryBuilder RowCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RowCountQueryBuilder> build)
        {
            var query = new Query<RowCount>("rowCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RowCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RowCount>(query);
            return this;
        }

        public ResourceOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}