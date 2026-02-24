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
    public sealed class QueryRootUrlRedirectsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootUrlRedirectsCountQueryBuilder>, IHasArguments<QueryRootUrlRedirectsCountArgumentsBuilder>
    {
        public QueryRootUrlRedirectsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootUrlRedirectsCountQueryBuilder Self => this;

        public QueryRootUrlRedirectsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootUrlRedirectsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootUrlRedirectsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootUrlRedirectsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootUrlRedirectsCountQueryBuilder SetArguments(Action<QueryRootUrlRedirectsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootUrlRedirectsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootUrlRedirectsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}