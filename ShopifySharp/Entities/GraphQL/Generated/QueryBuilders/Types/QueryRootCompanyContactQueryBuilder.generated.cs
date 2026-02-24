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
    public sealed class QueryRootCompanyContactQueryBuilder : FieldsQueryBuilderBase<CompanyContact, QueryRootCompanyContactQueryBuilder>, IHasArguments<QueryRootCompanyContactArgumentsBuilder>
    {
        public QueryRootCompanyContactArgumentsBuilder Arguments { get; }
        protected override QueryRootCompanyContactQueryBuilder Self => this;

        public QueryRootCompanyContactQueryBuilder(string name) : base(new Query<CompanyContact>(name))
        {
            Arguments = new QueryRootCompanyContactArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompanyContactQueryBuilder(IQuery<CompanyContact> query) : base(query)
        {
            Arguments = new QueryRootCompanyContactArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompanyContactQueryBuilder SetArguments(Action<QueryRootCompanyContactArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCompanyContactQueryBuilder Company(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public QueryRootCompanyContactQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootCompanyContactQueryBuilder Customer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public QueryRootCompanyContactQueryBuilder DraftOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderConnection>("draftOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderConnection>(query);
            return this;
        }

        public QueryRootCompanyContactQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCompanyContactQueryBuilder IsMainContact()
        {
            base.InnerQuery.AddField("isMainContact");
            return this;
        }

        public QueryRootCompanyContactQueryBuilder LifetimeDuration()
        {
            base.InnerQuery.AddField("lifetimeDuration");
            return this;
        }

        public QueryRootCompanyContactQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public QueryRootCompanyContactQueryBuilder Orders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public QueryRootCompanyContactQueryBuilder RoleAssignments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignmentConnection>("roleAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignmentConnection>(query);
            return this;
        }

        public QueryRootCompanyContactQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public QueryRootCompanyContactQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}