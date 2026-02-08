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
    public sealed class AppDiscountTypesOperationQueryBuilder : FieldsQueryBuilderBase<AppDiscountType, AppDiscountTypesOperationQueryBuilder>, IGraphOperationQueryBuilder<AppDiscountType>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override AppDiscountTypesOperationQueryBuilder Self => this;

        public AppDiscountTypesOperationQueryBuilder() : this("appDiscountTypes")
        {
        }

        public AppDiscountTypesOperationQueryBuilder(string name) : base(new Query<AppDiscountType>(name))
        {
        }

        public AppDiscountTypesOperationQueryBuilder(IQuery<AppDiscountType> query) : base(query)
        {
        }

        public AppDiscountTypesOperationQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppDiscountTypesOperationQueryBuilder AppBridge(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder> build)
        {
            var query = new Query<FunctionsAppBridge>("appBridge");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsAppBridge>(query);
            return this;
        }

        public AppDiscountTypesOperationQueryBuilder AppKey()
        {
            base.InnerQuery.AddField("appKey");
            return this;
        }

        public AppDiscountTypesOperationQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public AppDiscountTypesOperationQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public AppDiscountTypesOperationQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public AppDiscountTypesOperationQueryBuilder FunctionId()
        {
            base.InnerQuery.AddField("functionId");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public AppDiscountTypesOperationQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public AppDiscountTypesOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}