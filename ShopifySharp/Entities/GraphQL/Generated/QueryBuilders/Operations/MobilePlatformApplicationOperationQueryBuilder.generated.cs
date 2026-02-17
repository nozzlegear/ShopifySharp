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
    public sealed class MobilePlatformApplicationOperationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplication, MobilePlatformApplicationOperationQueryBuilder>, IGraphOperationQueryBuilder<MobilePlatformApplication>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public MobilePlatformApplicationArgumentsBuilder Arguments { get; }
        protected override MobilePlatformApplicationOperationQueryBuilder Self => this;

        public MobilePlatformApplicationOperationQueryBuilder() : this("mobilePlatformApplication")
        {
        }

        public MobilePlatformApplicationOperationQueryBuilder(string name) : base(new Query<MobilePlatformApplication>(name))
        {
            Arguments = new MobilePlatformApplicationArgumentsBuilder(base.InnerQuery);
        }

        public MobilePlatformApplicationOperationQueryBuilder(IQuery<MobilePlatformApplication> query) : base(query)
        {
            Arguments = new MobilePlatformApplicationArgumentsBuilder(base.InnerQuery);
        }
    }
}