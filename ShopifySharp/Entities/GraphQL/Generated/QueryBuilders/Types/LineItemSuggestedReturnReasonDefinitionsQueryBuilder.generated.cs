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
    public sealed class LineItemSuggestedReturnReasonDefinitionsQueryBuilder : FieldsQueryBuilderBase<ReturnReasonDefinitionConnection, LineItemSuggestedReturnReasonDefinitionsQueryBuilder>, IHasArguments<LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder>
    {
        public LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder Arguments { get; }
        protected override LineItemSuggestedReturnReasonDefinitionsQueryBuilder Self => this;

        public LineItemSuggestedReturnReasonDefinitionsQueryBuilder(string name) : base(new Query<ReturnReasonDefinitionConnection>(name))
        {
            Arguments = new LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public LineItemSuggestedReturnReasonDefinitionsQueryBuilder(IQuery<ReturnReasonDefinitionConnection> query) : base(query)
        {
            Arguments = new LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder(base.InnerQuery);
        }

        public LineItemSuggestedReturnReasonDefinitionsQueryBuilder SetArguments(Action<LineItemSuggestedReturnReasonDefinitionsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public LineItemSuggestedReturnReasonDefinitionsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinitionEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinitionEdge>(query);
            return this;
        }

        public LineItemSuggestedReturnReasonDefinitionsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }

        public LineItemSuggestedReturnReasonDefinitionsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}