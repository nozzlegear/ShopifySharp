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
    public sealed class CompanyContactQueryBuilder : FieldsQueryBuilderBase<CompanyContact, CompanyContactQueryBuilder>
    {
        protected override CompanyContactQueryBuilder Self => this;

        public CompanyContactQueryBuilder() : this("companyContact")
        {
        }

        public CompanyContactQueryBuilder(string name) : base(new Query<CompanyContact>(name))
        {
        }

        public CompanyContactQueryBuilder(IQuery<CompanyContact> query) : base(query)
        {
        }

        public CompanyContactQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyContactQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CompanyContactQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CompanyContactQueryBuilder DraftOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderConnection>("draftOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderConnection>(query);
            return this;
        }

        public CompanyContactQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyContactQueryBuilder IsMainContact()
        {
            base.InnerQuery.AddField("isMainContact");
            return this;
        }

        public CompanyContactQueryBuilder LifetimeDuration()
        {
            base.InnerQuery.AddField("lifetimeDuration");
            return this;
        }

        public CompanyContactQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CompanyContactQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public CompanyContactQueryBuilder RoleAssignments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignmentConnection>("roleAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignmentConnection>(query);
            return this;
        }

        public CompanyContactQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public CompanyContactQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}