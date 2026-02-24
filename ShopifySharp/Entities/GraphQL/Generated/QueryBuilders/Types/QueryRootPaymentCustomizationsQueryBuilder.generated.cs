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
    public sealed class QueryRootPaymentCustomizationsQueryBuilder : FieldsQueryBuilderBase<PaymentCustomizationConnection, QueryRootPaymentCustomizationsQueryBuilder>, IHasArguments<QueryRootPaymentCustomizationsArgumentsBuilder>
    {
        public QueryRootPaymentCustomizationsArgumentsBuilder Arguments { get; }
        protected override QueryRootPaymentCustomizationsQueryBuilder Self => this;

        public QueryRootPaymentCustomizationsQueryBuilder(string name) : base(new Query<PaymentCustomizationConnection>(name))
        {
            Arguments = new QueryRootPaymentCustomizationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPaymentCustomizationsQueryBuilder(IQuery<PaymentCustomizationConnection> query) : base(query)
        {
            Arguments = new QueryRootPaymentCustomizationsArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPaymentCustomizationsQueryBuilder SetArguments(Action<QueryRootPaymentCustomizationsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPaymentCustomizationsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationEdgeQueryBuilder> build)
        {
            var query = new Query<PaymentCustomizationEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomizationEdge>(query);
            return this;
        }

        public QueryRootPaymentCustomizationsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder> build)
        {
            var query = new Query<PaymentCustomization>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PaymentCustomizationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PaymentCustomization>(query);
            return this;
        }

        public QueryRootPaymentCustomizationsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}