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
    public sealed class PublicationsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, PublicationsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PublicationsCountArgumentsBuilder Arguments { get; }
        protected override PublicationsCountOperationQueryBuilder Self => this;

        public PublicationsCountOperationQueryBuilder() : this("publicationsCount")
        {
        }

        public PublicationsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new PublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public PublicationsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new PublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public PublicationsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public PublicationsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}