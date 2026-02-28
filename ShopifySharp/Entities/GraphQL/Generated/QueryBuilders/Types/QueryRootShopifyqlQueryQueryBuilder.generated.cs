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
    public sealed class QueryRootShopifyqlQueryQueryBuilder : FieldsQueryBuilderBase<ShopifyqlQueryResponse, QueryRootShopifyqlQueryQueryBuilder>, IHasArguments<QueryRootShopifyqlQueryArgumentsBuilder>
    {
        public QueryRootShopifyqlQueryArgumentsBuilder Arguments { get; }
        protected override QueryRootShopifyqlQueryQueryBuilder Self => this;

        public QueryRootShopifyqlQueryQueryBuilder(string name) : base(new Query<ShopifyqlQueryResponse>(name))
        {
            Arguments = new QueryRootShopifyqlQueryArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopifyqlQueryQueryBuilder(IQuery<ShopifyqlQueryResponse> query) : base(query)
        {
            Arguments = new QueryRootShopifyqlQueryArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootShopifyqlQueryQueryBuilder SetArguments(Action<QueryRootShopifyqlQueryArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootShopifyqlQueryQueryBuilder ParseErrors()
        {
            base.InnerQuery.AddField("parseErrors");
            return this;
        }

        public QueryRootShopifyqlQueryQueryBuilder TableData(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlTableDataQueryBuilder> build)
        {
            var query = new Query<ShopifyqlTableData>("tableData");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlTableDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyqlTableData>(query);
            return this;
        }
    }
}