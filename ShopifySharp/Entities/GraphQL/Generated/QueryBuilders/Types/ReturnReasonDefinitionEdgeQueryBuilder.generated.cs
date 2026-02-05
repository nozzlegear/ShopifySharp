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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class ReturnReasonDefinitionEdgeQueryBuilder : FieldsQueryBuilderBase<ReturnReasonDefinitionEdge, ReturnReasonDefinitionEdgeQueryBuilder>
    {
        protected override ReturnReasonDefinitionEdgeQueryBuilder Self => this;

        public ReturnReasonDefinitionEdgeQueryBuilder() : this("returnReasonDefinitionEdge")
        {
        }

        public ReturnReasonDefinitionEdgeQueryBuilder(string name) : base(new Query<ReturnReasonDefinitionEdge>(name))
        {
        }

        public ReturnReasonDefinitionEdgeQueryBuilder(IQuery<ReturnReasonDefinitionEdge> query) : base(query)
        {
        }

        public ReturnReasonDefinitionEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ReturnReasonDefinitionEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder> build)
        {
            var query = new Query<ReturnReasonDefinition>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnReasonDefinitionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReturnReasonDefinition>(query);
            return this;
        }
    }
}