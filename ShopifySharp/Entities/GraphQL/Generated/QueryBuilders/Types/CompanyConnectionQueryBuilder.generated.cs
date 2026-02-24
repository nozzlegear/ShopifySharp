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
    public sealed class CompanyConnectionQueryBuilder : FieldsQueryBuilderBase<CompanyConnection, CompanyConnectionQueryBuilder>, IHasArguments<CompanyConnectionArgumentsBuilder>
    {
        public CompanyConnectionArgumentsBuilder Arguments { get; }
        protected override CompanyConnectionQueryBuilder Self => this;

        public CompanyConnectionQueryBuilder() : this("companyConnection")
        {
        }

        public CompanyConnectionQueryBuilder(string name) : base(new Query<CompanyConnection>(name))
        {
            Arguments = new CompanyConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CompanyConnectionQueryBuilder(IQuery<CompanyConnection> query) : base(query)
        {
            Arguments = new CompanyConnectionArgumentsBuilder(base.InnerQuery);
        }

        public CompanyConnectionQueryBuilder SetArguments(Action<CompanyConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CompanyConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyEdgeQueryBuilder> build)
        {
            var query = new Query<CompanyEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyEdge>(query);
            return this;
        }

        public CompanyConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}