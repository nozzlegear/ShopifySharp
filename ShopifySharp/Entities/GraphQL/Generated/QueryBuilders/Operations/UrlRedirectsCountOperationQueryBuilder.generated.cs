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
    public sealed class UrlRedirectsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, UrlRedirectsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public UrlRedirectsCountArgumentsBuilder Arguments { get; }
        protected override UrlRedirectsCountOperationQueryBuilder Self => this;

        public UrlRedirectsCountOperationQueryBuilder() : this("urlRedirectsCount")
        {
        }

        public UrlRedirectsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new UrlRedirectsCountArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new UrlRedirectsCountArgumentsBuilder(base.InnerQuery);
        }

        public UrlRedirectsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public UrlRedirectsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}