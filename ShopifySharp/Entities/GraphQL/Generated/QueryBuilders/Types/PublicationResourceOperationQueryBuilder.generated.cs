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
    public sealed class PublicationResourceOperationQueryBuilder : FieldsQueryBuilderBase<PublicationResourceOperation, PublicationResourceOperationQueryBuilder>
    {
        protected override PublicationResourceOperationQueryBuilder Self => this;

        public PublicationResourceOperationQueryBuilder() : this("publicationResourceOperation")
        {
        }

        public PublicationResourceOperationQueryBuilder(string name) : base(new Query<PublicationResourceOperation>(name))
        {
        }

        public PublicationResourceOperationQueryBuilder(IQuery<PublicationResourceOperation> query) : base(query)
        {
        }

        public PublicationResourceOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public PublicationResourceOperationQueryBuilder ProcessedRowCount()
        {
            base.InnerQuery.AddField("processedRowCount");
            return this;
        }

        public PublicationResourceOperationQueryBuilder RowCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RowCountQueryBuilder> build)
        {
            var query = new Query<RowCount>("rowCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.RowCountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RowCount>(query);
            return this;
        }

        public PublicationResourceOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }
    }
}