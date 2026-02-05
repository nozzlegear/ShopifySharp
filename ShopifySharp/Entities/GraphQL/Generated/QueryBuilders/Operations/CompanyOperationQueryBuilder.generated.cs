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
    public sealed class CompanyOperationQueryBuilder : FieldsQueryBuilderBase<Company, CompanyOperationQueryBuilder>, IGraphOperationQueryBuilder<Company>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CompanyArgumentsBuilder Arguments { get; }
        protected override CompanyOperationQueryBuilder Self => this;

        public CompanyOperationQueryBuilder() : this("company")
        {
        }

        public CompanyOperationQueryBuilder(string name) : base(new Query<Company>(name))
        {
            Arguments = new CompanyArgumentsBuilder(base.InnerQuery);
        }

        public CompanyOperationQueryBuilder(IQuery<Company> query) : base(query)
        {
            Arguments = new CompanyArgumentsBuilder(base.InnerQuery);
        }

        [Obsolete("Use `contactsCount` instead.")]
        public CompanyOperationQueryBuilder ContactCount()
        {
            base.InnerQuery.AddField("contactCount");
            return this;
        }

        public CompanyOperationQueryBuilder ContactRoles(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleConnection>("contactRoles");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleConnection>(query);
            return this;
        }

        public CompanyOperationQueryBuilder Contacts(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyContactConnection>("contacts");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactConnection>(query);
            return this;
        }

        public CompanyOperationQueryBuilder ContactsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("contactsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CompanyOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CompanyOperationQueryBuilder CustomerSince()
        {
            base.InnerQuery.AddField("customerSince");
            return this;
        }

        public CompanyOperationQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public CompanyOperationQueryBuilder DefaultRole(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder> build)
        {
            var query = new Query<CompanyContactRole>("defaultRole");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactRoleQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRole>(query);
            return this;
        }

        public CompanyOperationQueryBuilder DraftOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderConnection>("draftOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderConnection>(query);
            return this;
        }

        public CompanyOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CompanyOperationQueryBuilder ExternalId()
        {
            base.InnerQuery.AddField("externalId");
            return this;
        }

        public CompanyOperationQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public CompanyOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyOperationQueryBuilder LifetimeDuration()
        {
            base.InnerQuery.AddField("lifetimeDuration");
            return this;
        }

        public CompanyOperationQueryBuilder Locations(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyLocationConnection>("locations");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyLocationConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationConnection>(query);
            return this;
        }

        public CompanyOperationQueryBuilder LocationsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("locationsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CompanyOperationQueryBuilder MainContact(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder> build)
        {
            var query = new Query<CompanyContact>("mainContact");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CompanyContactQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContact>(query);
            return this;
        }

        public CompanyOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public CompanyOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public CompanyOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public CompanyOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CompanyOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public CompanyOperationQueryBuilder Orders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public CompanyOperationQueryBuilder OrdersCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("ordersCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CompanyOperationQueryBuilder TotalSpent(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSpent");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CompanyOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}