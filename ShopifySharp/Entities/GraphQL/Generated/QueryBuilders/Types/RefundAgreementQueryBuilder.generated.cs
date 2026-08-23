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
    public sealed class RefundAgreementQueryBuilder : FieldsQueryBuilderBase<RefundAgreement, RefundAgreementQueryBuilder>
    {
        protected override RefundAgreementQueryBuilder Self => this;

        public RefundAgreementQueryBuilder() : this("refundAgreement")
        {
        }

        public RefundAgreementQueryBuilder(string name) : base(new Query<RefundAgreement>(name))
        {
        }

        public RefundAgreementQueryBuilder(IQuery<RefundAgreement> query) : base(query)
        {
        }

        public RefundAgreementQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public RefundAgreementQueryBuilder HappenedAt()
        {
            base.InnerQuery.AddField("happenedAt");
            return this;
        }

        public RefundAgreementQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public RefundAgreementQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }

        public RefundAgreementQueryBuilder Refund(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("refund");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }

        public RefundAgreementQueryBuilder Sales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleConnectionQueryBuilder> build)
        {
            var query = new Query<SaleConnection>("sales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleConnection>(query);
            return this;
        }

        public RefundAgreementQueryBuilder User(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("user");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }
    }
}