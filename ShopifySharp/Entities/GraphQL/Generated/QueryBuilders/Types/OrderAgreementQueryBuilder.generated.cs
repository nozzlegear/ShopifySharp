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
    public sealed class OrderAgreementQueryBuilder : FieldsQueryBuilderBase<OrderAgreement, OrderAgreementQueryBuilder>
    {
        protected override OrderAgreementQueryBuilder Self => this;

        public OrderAgreementQueryBuilder() : this("orderAgreement")
        {
        }

        public OrderAgreementQueryBuilder(string name) : base(new Query<OrderAgreement>(name))
        {
        }

        public OrderAgreementQueryBuilder(IQuery<OrderAgreement> query) : base(query)
        {
        }

        public OrderAgreementQueryBuilder App(Action<ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder> build)
        {
            var query = new Query<App>("app");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.AppQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<App>(query);
            return this;
        }

        public OrderAgreementQueryBuilder HappenedAt()
        {
            base.InnerQuery.AddField("happenedAt");
            return this;
        }

        public OrderAgreementQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public OrderAgreementQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public OrderAgreementQueryBuilder Reason()
        {
            base.InnerQuery.AddField("reason");
            return this;
        }

        public OrderAgreementQueryBuilder Sales(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SaleConnectionQueryBuilder> build)
        {
            var query = new Query<SaleConnection>("sales");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SaleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SaleConnection>(query);
            return this;
        }

        public OrderAgreementQueryBuilder User(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder> build)
        {
            var query = new Query<StaffMember>("user");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMember>(query);
            return this;
        }
    }
}