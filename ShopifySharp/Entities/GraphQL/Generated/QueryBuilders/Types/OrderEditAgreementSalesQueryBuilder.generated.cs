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
    public sealed class OrderEditAgreementSalesQueryBuilder : FieldsQueryBuilderBase<SaleConnection, OrderEditAgreementSalesQueryBuilder>, IHasArguments<OrderEditAgreementSalesArgumentsBuilder>
    {
        public OrderEditAgreementSalesArgumentsBuilder Arguments { get; }
        protected override OrderEditAgreementSalesQueryBuilder Self => this;

        public OrderEditAgreementSalesQueryBuilder(string name) : base(new Query<SaleConnection>(name))
        {
            Arguments = new OrderEditAgreementSalesArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAgreementSalesQueryBuilder(IQuery<SaleConnection> query) : base(query)
        {
            Arguments = new OrderEditAgreementSalesArgumentsBuilder(base.InnerQuery);
        }

        public OrderEditAgreementSalesQueryBuilder SetArguments(Action<OrderEditAgreementSalesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public OrderEditAgreementSalesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleEdgeQueryBuilder> build)
        {
            var query = new Query<SaleEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleEdge>(query);
            return this;
        }

        public OrderEditAgreementSalesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }

        public OrderEditAgreementSalesQueryBuilder Nodes(Action<SaleInterfaceCasesBuilder> build)
        {
            var query = new Query<ISale>("nodes");
            var unionBuilder = new SaleInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}