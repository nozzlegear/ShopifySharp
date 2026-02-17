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
    public sealed class CompanyContactEdgeQueryBuilder : FieldsQueryBuilderBase<CompanyContactEdge, CompanyContactEdgeQueryBuilder>
    {
        protected override CompanyContactEdgeQueryBuilder Self => this;

        public CompanyContactEdgeQueryBuilder() : this("companyContactEdge")
        {
        }

        public CompanyContactEdgeQueryBuilder(string name) : base(new Query<CompanyContactEdge>(name))
        {
        }

        public CompanyContactEdgeQueryBuilder(IQuery<CompanyContactEdge> query) : base(query)
        {
        }

        public CompanyContactEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CompanyContactEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }
    }
}