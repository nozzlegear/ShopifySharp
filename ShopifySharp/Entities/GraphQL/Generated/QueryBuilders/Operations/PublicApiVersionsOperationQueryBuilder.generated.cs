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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class PublicApiVersionsOperationQueryBuilder : FieldsQueryBuilderBase<ApiVersion, PublicApiVersionsOperationQueryBuilder>, IGraphOperationQueryBuilder<ApiVersion>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override PublicApiVersionsOperationQueryBuilder Self => this;

        public PublicApiVersionsOperationQueryBuilder() : this("publicApiVersions")
        {
        }

        public PublicApiVersionsOperationQueryBuilder(string name) : base(new Query<ApiVersion>(name))
        {
        }

        public PublicApiVersionsOperationQueryBuilder(IQuery<ApiVersion> query) : base(query)
        {
        }

        public PublicApiVersionsOperationQueryBuilder DisplayName()
        {
            base.InnerQuery.AddField("displayName");
            return this;
        }

        public PublicApiVersionsOperationQueryBuilder Handle()
        {
            base.InnerQuery.AddField("handle");
            return this;
        }

        public PublicApiVersionsOperationQueryBuilder Supported()
        {
            base.InnerQuery.AddField("supported");
            return this;
        }
    }
}