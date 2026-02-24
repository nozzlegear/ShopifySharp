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
    public sealed class QueryRootAbandonedCheckoutsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootAbandonedCheckoutsCountQueryBuilder>, IHasArguments<QueryRootAbandonedCheckoutsCountArgumentsBuilder>
    {
        public QueryRootAbandonedCheckoutsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootAbandonedCheckoutsCountQueryBuilder Self => this;

        public QueryRootAbandonedCheckoutsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootAbandonedCheckoutsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAbandonedCheckoutsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootAbandonedCheckoutsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootAbandonedCheckoutsCountQueryBuilder SetArguments(Action<QueryRootAbandonedCheckoutsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootAbandonedCheckoutsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootAbandonedCheckoutsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}