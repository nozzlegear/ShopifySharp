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
    public sealed class PagesCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, PagesCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public PagesCountArgumentsBuilder Arguments { get; }
        protected override PagesCountOperationQueryBuilder Self => this;

        public PagesCountOperationQueryBuilder() : this("pagesCount")
        {
        }

        public PagesCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new PagesCountArgumentsBuilder(base.InnerQuery);
        }

        public PagesCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new PagesCountArgumentsBuilder(base.InnerQuery);
        }

        public PagesCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public PagesCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}