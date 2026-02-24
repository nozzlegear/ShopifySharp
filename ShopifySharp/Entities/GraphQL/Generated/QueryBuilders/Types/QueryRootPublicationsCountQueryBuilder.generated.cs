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
    public sealed class QueryRootPublicationsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootPublicationsCountQueryBuilder>, IHasArguments<QueryRootPublicationsCountArgumentsBuilder>
    {
        public QueryRootPublicationsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootPublicationsCountQueryBuilder Self => this;

        public QueryRootPublicationsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootPublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPublicationsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootPublicationsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootPublicationsCountQueryBuilder SetArguments(Action<QueryRootPublicationsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootPublicationsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootPublicationsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}