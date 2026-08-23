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
    public sealed class SalesAgreementQueryBuilder : FieldsQueryBuilderBase<ISalesAgreement, SalesAgreementQueryBuilder>
    {
        protected override SalesAgreementQueryBuilder Self => this;

        public SalesAgreementQueryBuilder() : this("salesAgreement")
        {
        }

        public SalesAgreementQueryBuilder(string name) : base(new Query<ISalesAgreement>(name))
        {
        }

        public SalesAgreementQueryBuilder(IQuery<ISalesAgreement> query) : base(query)
        {
        }

        public SalesAgreementQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public SalesAgreementQueryBuilder HappenedAt()
        {
            base.InnerQuery.AddField("happenedAt");
            return this;
        }

        public SalesAgreementQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SalesAgreementQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }

        public SalesAgreementQueryBuilder Sales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleConnectionQueryBuilder> build)
        {
            var query = new Query<SaleConnection>("sales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleConnection>(query);
            return this;
        }

        public SalesAgreementQueryBuilder User(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("user");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }

        public SalesAgreementQueryBuilder OnOrderAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderAgreementQueryBuilder> build)
        {
            var query = new Query<OrderAgreement>("... on OrderAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SalesAgreementQueryBuilder OnOrderEditAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditAgreementQueryBuilder> build)
        {
            var query = new Query<OrderEditAgreement>("... on OrderEditAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderEditAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SalesAgreementQueryBuilder OnRefundAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundAgreementQueryBuilder> build)
        {
            var query = new Query<RefundAgreement>("... on RefundAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SalesAgreementQueryBuilder OnReturnAgreement(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReturnAgreementQueryBuilder> build)
        {
            var query = new Query<ReturnAgreement>("... on ReturnAgreement");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReturnAgreementQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }

        public SalesAgreementQueryBuilder SalesAgreement(Action<SalesAgreementInterfaceCasesBuilder> build)
        {
            var query = new Query<ISalesAgreement>("salesAgreement");
            var unionBuilder = new SalesAgreementInterfaceCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddInterfaceCase(query);
            return this;
        }
    }
}