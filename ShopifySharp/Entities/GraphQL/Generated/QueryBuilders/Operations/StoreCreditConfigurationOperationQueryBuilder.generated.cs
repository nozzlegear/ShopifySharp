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
    public sealed class StoreCreditConfigurationOperationQueryBuilder : FieldsQueryBuilderBase<StoreCreditConfiguration, StoreCreditConfigurationOperationQueryBuilder>, IGraphOperationQueryBuilder<StoreCreditConfiguration>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override StoreCreditConfigurationOperationQueryBuilder Self => this;

        public StoreCreditConfigurationOperationQueryBuilder() : this("storeCreditConfiguration")
        {
        }

        public StoreCreditConfigurationOperationQueryBuilder(string name) : base(new Query<StoreCreditConfiguration>(name))
        {
        }

        public StoreCreditConfigurationOperationQueryBuilder(IQuery<StoreCreditConfiguration> query) : base(query)
        {
        }

        public StoreCreditConfigurationOperationQueryBuilder StoreCreditEnabled()
        {
            base.InnerQuery.AddField("storeCreditEnabled");
            return this;
        }
    }
}