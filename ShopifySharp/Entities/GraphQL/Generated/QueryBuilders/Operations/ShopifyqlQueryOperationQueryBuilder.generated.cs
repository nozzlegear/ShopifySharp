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
    public sealed class ShopifyqlQueryOperationQueryBuilder : FieldsQueryBuilderBase<ShopifyqlQueryResponse, ShopifyqlQueryOperationQueryBuilder>, IGraphOperationQueryBuilder<ShopifyqlQueryResponse>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public ShopifyqlQueryArgumentsBuilder Arguments { get; }
        protected override ShopifyqlQueryOperationQueryBuilder Self => this;

        public ShopifyqlQueryOperationQueryBuilder() : this("shopifyqlQuery")
        {
        }

        public ShopifyqlQueryOperationQueryBuilder(string name) : base(new Query<ShopifyqlQueryResponse>(name))
        {
            Arguments = new ShopifyqlQueryArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyqlQueryOperationQueryBuilder(IQuery<ShopifyqlQueryResponse> query) : base(query)
        {
            Arguments = new ShopifyqlQueryArgumentsBuilder(base.InnerQuery);
        }

        public ShopifyqlQueryOperationQueryBuilder ParseErrors()
        {
            base.InnerQuery.AddField("parseErrors");
            return this;
        }

        public ShopifyqlQueryOperationQueryBuilder TableData(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlTableDataQueryBuilder> build)
        {
            var query = new Query<ShopifyqlTableData>("tableData");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlTableDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyqlTableData>(query);
            return this;
        }
    }
}