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
    public sealed class SalesAgreementSalesQueryBuilder : FieldsQueryBuilderBase<SaleConnection, SalesAgreementSalesQueryBuilder>, IHasArguments<SalesAgreementSalesArgumentsBuilder>
    {
        public SalesAgreementSalesArgumentsBuilder Arguments { get; }
        protected override SalesAgreementSalesQueryBuilder Self => this;

        public SalesAgreementSalesQueryBuilder(string name) : base(new Query<SaleConnection>(name))
        {
            Arguments = new SalesAgreementSalesArgumentsBuilder(base.InnerQuery);
        }

        public SalesAgreementSalesQueryBuilder(IQuery<SaleConnection> query) : base(query)
        {
            Arguments = new SalesAgreementSalesArgumentsBuilder(base.InnerQuery);
        }

        public SalesAgreementSalesQueryBuilder SetArguments(Action<SalesAgreementSalesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SalesAgreementSalesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleEdgeQueryBuilder> build)
        {
            var query = new Query<SaleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleEdge>(query);
            return this;
        }

        public SalesAgreementSalesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public SalesAgreementSalesQueryBuilder Nodes(Action<SaleInterfaceCasesBuilder> build)
        {
            var query = new Query<ISale>("nodes");
            var unionBuilder = new SaleInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}