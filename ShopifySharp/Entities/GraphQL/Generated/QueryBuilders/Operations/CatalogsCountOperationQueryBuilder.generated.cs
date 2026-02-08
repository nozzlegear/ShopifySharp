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
    public sealed class CatalogsCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, CatalogsCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CatalogsCountArgumentsBuilder Arguments { get; }
        protected override CatalogsCountOperationQueryBuilder Self => this;

        public CatalogsCountOperationQueryBuilder() : this("catalogsCount")
        {
        }

        public CatalogsCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CatalogsCountArgumentsBuilder(base.InnerQuery);
        }

        public CatalogsCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CatalogsCountArgumentsBuilder(base.InnerQuery);
        }

        public CatalogsCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CatalogsCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}