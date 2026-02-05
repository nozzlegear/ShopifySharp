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
    public sealed class DataSaleOptOutOperationQueryBuilder : FieldsQueryBuilderBase<DataSaleOptOutPayload, DataSaleOptOutOperationQueryBuilder>, IGraphOperationQueryBuilder<DataSaleOptOutPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public DataSaleOptOutArgumentsBuilder Arguments { get; }
        protected override DataSaleOptOutOperationQueryBuilder Self => this;

        public DataSaleOptOutOperationQueryBuilder() : this("dataSaleOptOut")
        {
        }

        public DataSaleOptOutOperationQueryBuilder(string name) : base(new Query<DataSaleOptOutPayload>(name))
        {
            Arguments = new DataSaleOptOutArgumentsBuilder(base.InnerQuery);
        }

        public DataSaleOptOutOperationQueryBuilder(IQuery<DataSaleOptOutPayload> query) : base(query)
        {
            Arguments = new DataSaleOptOutArgumentsBuilder(base.InnerQuery);
        }

        public DataSaleOptOutOperationQueryBuilder CustomerId()
        {
            base.InnerQuery.AddField("customerId");
            return this;
        }

        public DataSaleOptOutOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DataSaleOptOutUserErrorQueryBuilder> build)
        {
            var query = new Query<DataSaleOptOutUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DataSaleOptOutUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DataSaleOptOutUserError>(query);
            return this;
        }
    }
}