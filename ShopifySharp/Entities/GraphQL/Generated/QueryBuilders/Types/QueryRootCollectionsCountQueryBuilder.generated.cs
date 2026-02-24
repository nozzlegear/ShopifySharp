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
    public sealed class QueryRootCollectionsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootCollectionsCountQueryBuilder>, IHasArguments<QueryRootCollectionsCountArgumentsBuilder>
    {
        public QueryRootCollectionsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootCollectionsCountQueryBuilder Self => this;

        public QueryRootCollectionsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootCollectionsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCollectionsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootCollectionsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCollectionsCountQueryBuilder SetArguments(Action<QueryRootCollectionsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCollectionsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootCollectionsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}