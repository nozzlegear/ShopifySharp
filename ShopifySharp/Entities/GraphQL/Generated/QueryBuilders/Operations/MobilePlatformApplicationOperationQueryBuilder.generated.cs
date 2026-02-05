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