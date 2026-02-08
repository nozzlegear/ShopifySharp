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
    public sealed class AppDiscountTypeOperationQueryBuilder : FieldsQueryBuilderBase<AppDiscountType, AppDiscountTypeOperationQueryBuilder>, IGraphOperationQueryBuilder<AppDiscountType>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public AppDiscountTypeArgumentsBuilder Arguments { get; }
        protected override AppDiscountTypeOperationQueryBuilder Self => this;

        public AppDiscountTypeOperationQueryBuilder() : this("appDiscountType")
        {
        }

        public AppDiscountTypeOperationQueryBuilder(string name) : base(new Query<AppDiscountType>(name))
        {
            Arguments = new AppDiscountTypeArgumentsBuilder(base.InnerQuery);
        }

        public AppDiscountTypeOperationQueryBuilder(IQuery<AppDiscountType> query) : base(query)
        {
            Arguments = new AppDiscountTypeArgumentsBuilder(base.InnerQuery);
        }

        public AppDiscountTypeOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppDiscountTypeOperationQueryBuilder AppBridge(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder> build)
        {
            var query = new Query<FunctionsAppBridge>("appBridge");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsAppBridge>(query);
            return this;
        }

        public AppDiscountTypeOperationQueryBuilder AppKey()
        {
            base.InnerQuery.AddField("appKey");
            return this;
        }

        public AppDiscountTypeOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public AppDiscountTypeOperationQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public AppDiscountTypeOperationQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public AppDiscountTypeOperationQueryBuilder FunctionId()
        {
            base.InnerQuery.AddField("functionId");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public AppDiscountTypeOperationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public AppDiscountTypeOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}