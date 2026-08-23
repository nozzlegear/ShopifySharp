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
    public sealed class OrderAgreementSalesQueryBuilder : FieldsQueryBuilderBase<SaleConnection, OrderAgreementSalesQueryBuilder>, IHasArguments<OrderAgreementSalesArgumentsBuilder>
    {
        public OrderAgreementSalesArgumentsBuilder Arguments { get; }
        protected override OrderAgreementSalesQueryBuilder Self => this;

        public OrderAgreementSalesQueryBuilder(string name) : base(new Query<SaleConnection>(name))
        {
            Arguments = new OrderAgreementSalesArgumentsBuilder(base.InnerQuery);
        }

        public OrderAgreementSalesQueryBuilder(IQuery<SaleConnection> query) : base(query)
        {
            Arguments = new OrderAgreementSalesArgumentsBuilder(base.InnerQuery);
        }

        public OrderAgreementSalesQueryBuilder SetArguments(Action<OrderAgreementSalesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderAgreementSalesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleEdgeQueryBuilder> build)
        {
            var query = new Query<SaleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleEdge>(query);
            return this;
        }

        public OrderAgreementSalesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public OrderAgreementSalesQueryBuilder Nodes(Action<SaleInterfaceCasesBuilder> build)
        {
            var query = new Query<ISale>("nodes");
            var unionBuilder = new SaleInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}