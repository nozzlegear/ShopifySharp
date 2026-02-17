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
    public sealed class CollectionsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, CollectionsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CollectionsCountArgumentsBuilder Arguments { get; }
        protected override CollectionsCountOperationQueryBuilder Self => this;

        public CollectionsCountOperationQueryBuilder() : this("collectionsCount")
        {
        }

        public CollectionsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CollectionsCountArgumentsBuilder(base.InnerQuery);
        }

        public CollectionsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CollectionsCountArgumentsBuilder(base.InnerQuery);
        }

        public CollectionsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CollectionsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}