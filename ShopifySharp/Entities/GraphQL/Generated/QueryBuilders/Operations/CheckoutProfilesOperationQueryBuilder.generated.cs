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
    public sealed class CheckoutProfilesOperationQueryBuilder : FieldsQueryBuilderBase<CheckoutProfileConnection, CheckoutProfilesOperationQueryBuilder>, IGraphOperationQueryBuilder<CheckoutProfileConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CheckoutProfilesArgumentsBuilder Arguments { get; }
        protected override CheckoutProfilesOperationQueryBuilder Self => this;

        public CheckoutProfilesOperationQueryBuilder() : this("checkoutProfiles")
        {
        }

        public CheckoutProfilesOperationQueryBuilder(string name) : base(new Query<CheckoutProfileConnection>(name))
        {
            Arguments = new CheckoutProfilesArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutProfilesOperationQueryBuilder(IQuery<CheckoutProfileConnection> query) : base(query)
        {
            Arguments = new CheckoutProfilesArgumentsBuilder(base.InnerQuery);
        }

        public CheckoutProfilesOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileEdgeQueryBuilder> build)
        {
            var query = new Query<CheckoutProfileEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfileEdge>(query);
            return this;
        }

        public CheckoutProfilesOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileQueryBuilder> build)
        {
            var query = new Query<CheckoutProfile>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CheckoutProfileQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CheckoutProfile>(query);
            return this;
        }

        public CheckoutProfilesOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}