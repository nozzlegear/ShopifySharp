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
    public sealed class ReturnAgreementQueryBuilder : FieldsQueryBuilderBase<ReturnAgreement, ReturnAgreementQueryBuilder>
    {
        protected override ReturnAgreementQueryBuilder Self => this;

        public ReturnAgreementQueryBuilder() : this("returnAgreement")
        {
        }

        public ReturnAgreementQueryBuilder(string name) : base(new Query<ReturnAgreement>(name))
        {
        }

        public ReturnAgreementQueryBuilder(IQuery<ReturnAgreement> query) : base(query)
        {
        }

        public ReturnAgreementQueryBuilder App(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public ReturnAgreementQueryBuilder HappenedAt()
        {
            base.InnerQuery.AddField("happenedAt");
            return this;
        }

        public ReturnAgreementQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReturnAgreementQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }

        public ReturnAgreementQueryBuilder Return(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder> build)
        {
            var query = new Query<Return>("return");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ReturnQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Return>(query);
            return this;
        }

        public ReturnAgreementQueryBuilder Sales(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SaleConnectionQueryBuilder> build)
        {
            var query = new Query<SaleConnection>("sales");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SaleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleConnection>(query);
            return this;
        }

        public ReturnAgreementQueryBuilder User(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("user");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }
    }
}