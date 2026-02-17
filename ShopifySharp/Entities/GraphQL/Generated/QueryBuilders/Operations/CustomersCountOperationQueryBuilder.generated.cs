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
    public sealed class CustomersCountOperationQueryBuilder : FieldsQueryBuilderBase<Count, CustomersCountOperationQueryBuilder>, IGraphOperationQueryBuilder<Count>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CustomersCountArgumentsBuilder Arguments { get; }
        protected override CustomersCountOperationQueryBuilder Self => this;

        public CustomersCountOperationQueryBuilder() : this("customersCount")
        {
        }

        public CustomersCountOperationQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new CustomersCountArgumentsBuilder(base.InnerQuery);
        }

        public CustomersCountOperationQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new CustomersCountArgumentsBuilder(base.InnerQuery);
        }

        public CustomersCountOperationQueryBuilder Count()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public CustomersCountOperationQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}