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
    public sealed class QueryRootCompaniesCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootCompaniesCountQueryBuilder>, IHasArguments<QueryRootCompaniesCountArgumentsBuilder>
    {
        public QueryRootCompaniesCountArgumentsBuilder Arguments { get; }
        protected override QueryRootCompaniesCountQueryBuilder Self => this;

        public QueryRootCompaniesCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootCompaniesCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompaniesCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootCompaniesCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompaniesCountQueryBuilder SetArguments(Action<QueryRootCompaniesCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCompaniesCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootCompaniesCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}