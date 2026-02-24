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
    public sealed class QueryRootDiscountNodesCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootDiscountNodesCountQueryBuilder>, IHasArguments<QueryRootDiscountNodesCountArgumentsBuilder>
    {
        public QueryRootDiscountNodesCountArgumentsBuilder Arguments { get; }
        protected override QueryRootDiscountNodesCountQueryBuilder Self => this;

        public QueryRootDiscountNodesCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootDiscountNodesCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDiscountNodesCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootDiscountNodesCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDiscountNodesCountQueryBuilder SetArguments(Action<QueryRootDiscountNodesCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDiscountNodesCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootDiscountNodesCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}