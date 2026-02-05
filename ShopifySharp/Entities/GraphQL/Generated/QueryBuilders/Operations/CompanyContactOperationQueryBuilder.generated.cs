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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CompanyContactOperationQueryBuilder : FieldsQueryBuilderBase<CompanyContact, CompanyContactOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyContact>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CompanyContactArgumentsBuilder Arguments { get; }
        protected override CompanyContactOperationQueryBuilder Self => this;

        public CompanyContactOperationQueryBuilder() : this("companyContact")
        {
        }

        public CompanyContactOperationQueryBuilder(string name) : base(new Query<CompanyContact>(name))
        {
            Arguments = new CompanyContactArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactOperationQueryBuilder(IQuery<CompanyContact> query) : base(query)
        {
            Arguments = new CompanyContactArgumentsBuilder(base.InnerQuery);
        }

        public CompanyContactOperationQueryBuilder Company(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyContactOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CompanyContactOperationQueryBuilder Customer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder> build)
        {
            var query = new Query<Customer>("customer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CustomerQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Customer>(query);
            return this;
        }

        public CompanyContactOperationQueryBuilder DraftOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderConnection>("draftOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderConnection>(query);
            return this;
        }

        public CompanyContactOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyContactOperationQueryBuilder IsMainContact()
        {
            base.InnerQuery.AddField("isMainContact");
            return this;
        }

        public CompanyContactOperationQueryBuilder LifetimeDuration()
        {
            base.InnerQuery.AddField("lifetimeDuration");
            return this;
        }

        public CompanyContactOperationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CompanyContactOperationQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public CompanyContactOperationQueryBuilder RoleAssignments(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignmentConnection>("roleAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignmentConnection>(query);
            return this;
        }

        public CompanyContactOperationQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public CompanyContactOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}