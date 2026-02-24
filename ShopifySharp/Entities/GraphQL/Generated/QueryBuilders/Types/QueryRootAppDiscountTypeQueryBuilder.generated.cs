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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class QueryRootAppDiscountTypeQueryBuilder : FieldsQueryBuilderBase<AppDiscountType, QueryRootAppDiscountTypeQueryBuilder>, IHasArguments<QueryRootAppDiscountTypeArgumentsBuilder>
    {
        public QueryRootAppDiscountTypeArgumentsBuilder Arguments { get; }
        protected override QueryRootAppDiscountTypeQueryBuilder Self => this;

        public QueryRootAppDiscountTypeQueryBuilder(string name) : base(new Query<AppDiscountType>(name))
        {
            Arguments = new QueryRootAppDiscountTypeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAppDiscountTypeQueryBuilder(IQuery<AppDiscountType> query) : base(query)
        {
            Arguments = new QueryRootAppDiscountTypeArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAppDiscountTypeQueryBuilder SetArguments(Action<QueryRootAppDiscountTypeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootAppDiscountTypeQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public QueryRootAppDiscountTypeQueryBuilder AppBridge(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder> build)
        {
            var query = new Query<FunctionsAppBridge>("appBridge");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsAppBridge>(query);
            return this;
        }

        public QueryRootAppDiscountTypeQueryBuilder AppKey()
        {
            base.InnerQuery.AddField("appKey");
            return this;
        }

        public QueryRootAppDiscountTypeQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public QueryRootAppDiscountTypeQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public QueryRootAppDiscountTypeQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public QueryRootAppDiscountTypeQueryBuilder FunctionId()
        {
            base.InnerQuery.AddField("functionId");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public QueryRootAppDiscountTypeQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public QueryRootAppDiscountTypeQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}