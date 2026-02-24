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
    public sealed class QueryRootDiscountCodesCountQueryBuilder : FieldsQueryBuilderBase<Count, QueryRootDiscountCodesCountQueryBuilder>, IHasArguments<QueryRootDiscountCodesCountArgumentsBuilder>
    {
        public QueryRootDiscountCodesCountArgumentsBuilder Arguments { get; }
        protected override QueryRootDiscountCodesCountQueryBuilder Self => this;

        public QueryRootDiscountCodesCountQueryBuilder(string name) : base(new Query<Count>(name))
        {
            Arguments = new QueryRootDiscountCodesCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDiscountCodesCountQueryBuilder(IQuery<Count> query) : base(query)
        {
            Arguments = new QueryRootDiscountCodesCountArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootDiscountCodesCountQueryBuilder SetArguments(Action<QueryRootDiscountCodesCountArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootDiscountCodesCountQueryBuilder Count_()
        {
            base.InnerQuery.AddField("count");
            return this;
        }

        public QueryRootDiscountCodesCountQueryBuilder Precision()
        {
            base.InnerQuery.AddField("precision");
            return this;
        }
    }
}