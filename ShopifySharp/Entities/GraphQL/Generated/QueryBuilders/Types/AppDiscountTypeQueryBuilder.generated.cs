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
    public sealed class AppDiscountTypeQueryBuilder : FieldsQueryBuilderBase<AppDiscountType, AppDiscountTypeQueryBuilder>, IHasArguments<AppDiscountTypeArgumentsBuilder>
    {
        public AppDiscountTypeArgumentsBuilder Arguments { get; }
        protected override AppDiscountTypeQueryBuilder Self => this;

        public AppDiscountTypeQueryBuilder() : this("appDiscountType")
        {
        }

        public AppDiscountTypeQueryBuilder(string name) : base(new Query<AppDiscountType>(name))
        {
            Arguments = new AppDiscountTypeArgumentsBuilder(base.InnerQuery);
        }

        public AppDiscountTypeQueryBuilder(IQuery<AppDiscountType> query) : base(query)
        {
            Arguments = new AppDiscountTypeArgumentsBuilder(base.InnerQuery);
        }

        public AppDiscountTypeQueryBuilder SetArguments(Action<AppDiscountTypeArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public AppDiscountTypeQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public AppDiscountTypeQueryBuilder AppBridge(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder> build)
        {
            var query = new Query<FunctionsAppBridge>("appBridge");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FunctionsAppBridgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FunctionsAppBridge>(query);
            return this;
        }

        public AppDiscountTypeQueryBuilder AppKey()
        {
            base.InnerQuery.AddField("appKey");
            return this;
        }

        public AppDiscountTypeQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public AppDiscountTypeQueryBuilder DiscountClass()
        {
            base.InnerQuery.AddField("discountClass");
            return this;
        }

        public AppDiscountTypeQueryBuilder DiscountClasses()
        {
            base.InnerQuery.AddField("discountClasses");
            return this;
        }

        public AppDiscountTypeQueryBuilder FunctionId()
        {
            base.InnerQuery.AddField("functionId");
            return this;
        }

        [Obsolete("Use `discountClasses` instead.")]
        public AppDiscountTypeQueryBuilder TargetType()
        {
            base.InnerQuery.AddField("targetType");
            return this;
        }

        public AppDiscountTypeQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}