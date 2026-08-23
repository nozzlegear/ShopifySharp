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
    public sealed class MobilePlatformApplicationOperationQueryBuilder : FieldsQueryBuilderBase<MobilePlatformApplication, MobilePlatformApplicationOperationQueryBuilder>, IGraphOperationQueryBuilder<MobilePlatformApplication>, IHasArguments<MobilePlatformApplicationArgumentsBuilder>
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

        public MobilePlatformApplicationOperationQueryBuilder SetArguments(Action<MobilePlatformApplicationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MobilePlatformApplicationOperationQueryBuilder OnAndroidApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AndroidApplicationQueryBuilder> build)
        {
            var query = new Query<AndroidApplication>("... on AndroidApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AndroidApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }

        public MobilePlatformApplicationOperationQueryBuilder OnAppleApplication(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppleApplicationQueryBuilder> build)
        {
            var query = new Query<AppleApplication>("... on AppleApplication");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppleApplicationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}