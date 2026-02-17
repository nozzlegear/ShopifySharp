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
    public sealed class ShopifyqlQueryResponseQueryBuilder : FieldsQueryBuilderBase<ShopifyqlQueryResponse, ShopifyqlQueryResponseQueryBuilder>
    {
        protected override ShopifyqlQueryResponseQueryBuilder Self => this;

        public ShopifyqlQueryResponseQueryBuilder() : this("shopifyqlQueryResponse")
        {
        }

        public ShopifyqlQueryResponseQueryBuilder(string name) : base(new Query<ShopifyqlQueryResponse>(name))
        {
        }

        public ShopifyqlQueryResponseQueryBuilder(IQuery<ShopifyqlQueryResponse> query) : base(query)
        {
        }

        public ShopifyqlQueryResponseQueryBuilder ParseErrors()
        {
            base.InnerQuery.AddField("parseErrors");
            return this;
        }

        public ShopifyqlQueryResponseQueryBuilder TableData(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlTableDataQueryBuilder> build)
        {
            var query = new Query<ShopifyqlTableData>("tableData");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopifyqlTableDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopifyqlTableData>(query);
            return this;
        }
    }
}