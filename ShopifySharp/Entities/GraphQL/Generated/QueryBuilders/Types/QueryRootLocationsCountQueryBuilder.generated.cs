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
    public sealed class QueryRootLocationsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootLocationsCountQueryBuilder>, IHasArguments<QueryRootLocationsCountArgumentsBuilder>
    {
        public QueryRootLocationsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootLocationsCountQueryBuilder Self => this;

        public QueryRootLocationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootLocationsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootLocationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootLocationsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootLocationsCountQueryBuilder SetArguments(Action<QueryRootLocationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootLocationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootLocationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}