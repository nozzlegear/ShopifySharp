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
    public sealed class MetafieldReferencePaymentMethodsQueryBuilder : FieldsQueryBuilderBase<CustomerPaymentMethodConnection, MetafieldReferencePaymentMethodsQueryBuilder>, IHasArguments<MetafieldReferencePaymentMethodsArgumentsBuilder>
    {
        public MetafieldReferencePaymentMethodsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencePaymentMethodsQueryBuilder Self => this;

        public MetafieldReferencePaymentMethodsQueryBuilder(string name) : base(new Query<CustomerPaymentMethodConnection>(name))
        {
            Arguments = new MetafieldReferencePaymentMethodsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencePaymentMethodsQueryBuilder(IQuery<CustomerPaymentMethodConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencePaymentMethodsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencePaymentMethodsQueryBuilder SetArguments(Action<MetafieldReferencePaymentMethodsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencePaymentMethodsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodEdgeQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethodEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethodEdge>(query);
            return this;
        }

        public MetafieldReferencePaymentMethodsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder> build)
        {
            var query = new Query<CustomerPaymentMethod>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerPaymentMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CustomerPaymentMethod>(query);
            return this;
        }

        public MetafieldReferencePaymentMethodsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}