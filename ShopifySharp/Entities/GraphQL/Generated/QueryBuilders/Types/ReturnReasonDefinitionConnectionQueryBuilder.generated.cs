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
    public sealed class ReturnReasonDefinitionConnectionQueryBuilder : FieldsQueryBuilderBase<ReturnReasonDefinitionConnection, ReturnReasonDefinitionConnectionQueryBuilder>, IHasArguments<ReturnReasonDefinitionConnectionArgumentsBuilder>
    {
        public ReturnReasonDefinitionConnectionArgumentsBuilder Arguments { get; }
        protected override ReturnReasonDefinitionConnectionQueryBuilder Self => this;

        public ReturnReasonDefinitionConnectionQueryBuilder() : this("returnReasonDefinitionConnection")
        {
        }

        public ReturnReasonDefinitionConnectionQueryBuilder(string name) : base(new Query<ReturnReasonDefinitionConnection>(name))
        {
            Arguments = new ReturnReasonDefinitionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public ReturnReasonDefinitionConnectionQueryBuilder(IQuery<ReturnReasonDefinitionConnection> query) : base(query)
        {
            Arguments = new ReturnReasonDefinitionConnectionArgumentsBuilder(base.InnerQuery);
        }

        public ReturnReasonDefinitionConnectionQueryBuilder SetArguments(Action<ReturnReasonDefinitionConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public ReturnReasonDefinitionConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinitionEdge>(query);
            return this;
        }

        public ReturnReasonDefinitionConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }

        public ReturnReasonDefinitionConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}