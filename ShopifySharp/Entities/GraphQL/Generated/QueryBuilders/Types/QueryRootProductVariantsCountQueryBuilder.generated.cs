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
    public sealed class QueryRootProductVariantsCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootProductVariantsCountQueryBuilder>, IHasArguments<QueryRootProductVariantsCountArgumentsBuilder>
    {
        public QueryRootProductVariantsCountArgumentsBuilder Arguments { get; }
        protected override QueryRootProductVariantsCountQueryBuilder Self => this;

        public QueryRootProductVariantsCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootProductVariantsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductVariantsCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootProductVariantsCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootProductVariantsCountQueryBuilder SetArguments(Action<QueryRootProductVariantsCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootProductVariantsCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootProductVariantsCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}