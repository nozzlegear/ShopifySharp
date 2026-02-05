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
    public sealed class AppCreditEdgeQueryBuilder : FieldsQueryBuilderBase<AppCreditEdge, AppCreditEdgeQueryBuilder>
    {
        protected override AppCreditEdgeQueryBuilder Self => this;

        public AppCreditEdgeQueryBuilder() : this("appCreditEdge")
        {
        }

        public AppCreditEdgeQueryBuilder(string name) : base(new Query<AppCreditEdge>(name))
        {
        }

        public AppCreditEdgeQueryBuilder(IQuery<AppCreditEdge> query) : base(query)
        {
        }

        public AppCreditEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public AppCreditEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppCreditQueryBuilder> build)
        {
            var query = new Query<AppCredit>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppCreditQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<AppCredit>(query);
            return this;
        }
    }
}