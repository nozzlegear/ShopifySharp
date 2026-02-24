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
    public sealed class DiscountCodeNodeConnectionQueryBuilder : FieldsQueryBuilderBase<DiscountCodeNodeConnection, DiscountCodeNodeConnectionQueryBuilder>, IHasArguments<DiscountCodeNodeConnectionArgumentsBuilder>
    {
        public DiscountCodeNodeConnectionArgumentsBuilder Arguments { get; }
        protected override DiscountCodeNodeConnectionQueryBuilder Self => this;

        public DiscountCodeNodeConnectionQueryBuilder() : this("discountCodeNodeConnection")
        {
        }

        public DiscountCodeNodeConnectionQueryBuilder(string name) : base(new Query<DiscountCodeNodeConnection>(name))
        {
            Arguments = new DiscountCodeNodeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeNodeConnectionQueryBuilder(IQuery<DiscountCodeNodeConnection> query) : base(query)
        {
            Arguments = new DiscountCodeNodeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public DiscountCodeNodeConnectionQueryBuilder SetArguments(Action<DiscountCodeNodeConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public DiscountCodeNodeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeEdgeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNodeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNodeEdge>(query);
            return this;
        }

        public DiscountCodeNodeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder> build)
        {
            var query = new Query<DiscountCodeNode>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DiscountCodeNodeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DiscountCodeNode>(query);
            return this;
        }

        public DiscountCodeNodeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}