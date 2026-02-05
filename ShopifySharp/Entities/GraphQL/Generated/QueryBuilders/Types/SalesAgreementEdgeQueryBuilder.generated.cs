#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SalesAgreementEdgeQueryBuilder : FieldsQueryBuilderBase<SalesAgreementEdge, SalesAgreementEdgeQueryBuilder>
    {
        protected override SalesAgreementEdgeQueryBuilder Self => this;

        public SalesAgreementEdgeQueryBuilder() : this("salesAgreementEdge")
        {
        }

        public SalesAgreementEdgeQueryBuilder(string name) : base(new Query<SalesAgreementEdge>(name))
        {
        }

        public SalesAgreementEdgeQueryBuilder(IQuery<SalesAgreementEdge> query) : base(query)
        {
        }

        public SalesAgreementEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public SalesAgreementEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SalesAgreementQueryBuilder> build)
        {
            var query = new Query<ISalesAgreement>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SalesAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISalesAgreement>(query);
            return this;
        }
    }
}