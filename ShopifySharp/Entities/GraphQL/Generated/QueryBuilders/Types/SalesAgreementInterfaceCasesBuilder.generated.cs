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
    public sealed class SalesAgreementInterfaceCasesBuilder : InterfaceCasesBuilderBase<ISalesAgreement, SalesAgreementInterfaceCasesBuilder>
    {
        protected override SalesAgreementInterfaceCasesBuilder Self => this;

        public SalesAgreementInterfaceCasesBuilder(string fieldName = "node") : this(new Query<ISalesAgreement>(fieldName))
        {
        }

        public SalesAgreementInterfaceCasesBuilder(IQuery<ISalesAgreement> query) : base(query)
        {
        }

        public SalesAgreementInterfaceCasesBuilder OnOrderAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAgreementQueryBuilder> build)
        {
            var query = new Query<OrderAgreement>("... on OrderAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SalesAgreementInterfaceCasesBuilder OnOrderEditAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditAgreementQueryBuilder> build)
        {
            var query = new Query<OrderEditAgreement>("... on OrderEditAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SalesAgreementInterfaceCasesBuilder OnRefundAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundAgreementQueryBuilder> build)
        {
            var query = new Query<RefundAgreement>("... on RefundAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SalesAgreementInterfaceCasesBuilder OnReturnAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnAgreementQueryBuilder> build)
        {
            var query = new Query<ReturnAgreement>("... on ReturnAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}