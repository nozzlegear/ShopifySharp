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
    public sealed class ReturnLineItemTypeConnectionQueryBuilder : FieldsQueryBuilderBase<ReturnLineItemTypeConnection, ReturnLineItemTypeConnectionQueryBuilder>, IHasArguments<ReturnLineItemTypeConnectionArgumentsBuilder>
    {
        public ReturnLineItemTypeConnectionArgumentsBuilder Arguments { get; }
        protected override ReturnLineItemTypeConnectionQueryBuilder Self => this;

        public ReturnLineItemTypeConnectionQueryBuilder() : this("returnLineItemTypeConnection")
        {
        }

        public ReturnLineItemTypeConnectionQueryBuilder(string name) : base(new Query<ReturnLineItemTypeConnection>(name))
        {
            Arguments = new ReturnLineItemTypeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public ReturnLineItemTypeConnectionQueryBuilder(IQuery<ReturnLineItemTypeConnection> query) : base(query)
        {
            Arguments = new ReturnLineItemTypeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public ReturnLineItemTypeConnectionQueryBuilder SetArguments(Action<ReturnLineItemTypeConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ReturnLineItemTypeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemTypeEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnLineItemTypeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemTypeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnLineItemTypeEdge>(query);
            return this;
        }

        public ReturnLineItemTypeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemTypeQueryBuilder> build)
        {
            var query = new Query<IReturnLineItemType>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnLineItemTypeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<IReturnLineItemType>(query);
            return this;
        }

        public ReturnLineItemTypeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}