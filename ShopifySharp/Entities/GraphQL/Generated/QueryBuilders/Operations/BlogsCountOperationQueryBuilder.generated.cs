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
    public sealed class BlogsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, BlogsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public BlogsCountArgumentsBuilder Arguments { get; }
        protected override BlogsCountOperationQueryBuilder Self => this;

        public BlogsCountOperationQueryBuilder() : this("blogsCount")
        {
        }

        public BlogsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new BlogsCountArgumentsBuilder(base.InnerQuery);
        }

        public BlogsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new BlogsCountArgumentsBuilder(base.InnerQuery);
        }

        public BlogsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public BlogsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}