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
    public sealed class CompanyEdgeQueryBuilder : FieldsQueryBuilderBase<CompanyEdge, CompanyEdgeQueryBuilder>
    {
        protected override CompanyEdgeQueryBuilder Self => this;

        public CompanyEdgeQueryBuilder() : this("companyEdge")
        {
        }

        public CompanyEdgeQueryBuilder(string name) : base(new Query<CompanyEdge>(name))
        {
        }

        public CompanyEdgeQueryBuilder(IQuery<CompanyEdge> query) : base(query)
        {
        }

        public CompanyEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public CompanyEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }
    }
}