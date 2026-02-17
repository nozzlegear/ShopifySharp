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
    public sealed class CompanyLocationEdgeQueryBuilder : FieldsQueryBuilderBase<CompanyLocationEdge, CompanyLocationEdgeQueryBuilder>
    {
        protected override CompanyLocationEdgeQueryBuilder Self => this;

        public CompanyLocationEdgeQueryBuilder() : this("companyLocationEdge")
        {
        }

        public CompanyLocationEdgeQueryBuilder(string name) : base(new Query<CompanyLocationEdge>(name))
        {
        }

        public CompanyLocationEdgeQueryBuilder(IQuery<CompanyLocationEdge> query) : base(query)
        {
        }

        public CompanyLocationEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CompanyLocationEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder> build)
        {
            var query = new Query<CompanyLocation>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocation>(query);
            return this;
        }
    }
}