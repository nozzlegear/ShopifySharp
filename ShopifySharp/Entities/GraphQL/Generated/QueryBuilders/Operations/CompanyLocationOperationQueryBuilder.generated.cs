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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class CompanyLocationOperationQueryBuilder : FieldsQueryBuilderBase<CompanyLocation, CompanyLocationOperationQueryBuilder>, IGraphOperationQueryBuilder<CompanyLocation>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public CompanyLocationArgumentsBuilder Arguments { get; }
        protected override CompanyLocationOperationQueryBuilder Self => this;

        public CompanyLocationOperationQueryBuilder() : this("companyLocation")
        {
        }

        public CompanyLocationOperationQueryBuilder(string name) : base(new Query<CompanyLocation>(name))
        {
            Arguments = new CompanyLocationArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationOperationQueryBuilder(IQuery<CompanyLocation> query) : base(query)
        {
            Arguments = new CompanyLocationArgumentsBuilder(base.InnerQuery);
        }

        public CompanyLocationOperationQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder> build)
        {
            var query = new Query<CompanyAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyAddress>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder BuyerExperienceConfiguration(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BuyerExperienceConfigurationQueryBuilder> build)
        {
            var query = new Query<BuyerExperienceConfiguration>("buyerExperienceConfiguration");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BuyerExperienceConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BuyerExperienceConfiguration>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogConnectionQueryBuilder> build)
        {
            var query = new Query<CatalogConnection>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogConnection>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder CatalogsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("catalogsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder Company(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CompanyLocationOperationQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public CompanyLocationOperationQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public CompanyLocationOperationQueryBuilder DraftOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderConnection>("draftOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderConnection>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder ExternalId()
        {
            base.InnerQuery.AddField("externalId");
            return this;
        }

        public CompanyLocationOperationQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public CompanyLocationOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyLocationOperationQueryBuilder InCatalog()
        {
            base.InnerQuery.AddField("inCatalog");
            return this;
        }

        public CompanyLocationOperationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CompanyLocationOperationQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CompanyLocationOperationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        [Obsolete("Use `ordersCount` instead.")]
        public CompanyLocationOperationQueryBuilder OrderCount()
        {
            base.InnerQuery.AddField("orderCount");
            return this;
        }

        public CompanyLocationOperationQueryBuilder Orders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder OrdersCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("ordersCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public CompanyLocationOperationQueryBuilder RoleAssignments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignmentConnection>("roleAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignmentConnection>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder> build)
        {
            var query = new Query<CompanyAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyAddress>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder StaffMemberAssignments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignmentConnection>("staffMemberAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignmentConnection>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder StoreCreditAccounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountConnection>("storeCreditAccounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountConnection>(query);
            return this;
        }

        [Obsolete("Use `taxSettings` instead.")]
        public CompanyLocationOperationQueryBuilder TaxExemptions()
        {
            base.InnerQuery.AddField("taxExemptions");
            return this;
        }

        [Obsolete("Use `taxSettings` instead.")]
        public CompanyLocationOperationQueryBuilder TaxRegistrationId()
        {
            base.InnerQuery.AddField("taxRegistrationId");
            return this;
        }

        public CompanyLocationOperationQueryBuilder TaxSettings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationTaxSettingsQueryBuilder> build)
        {
            var query = new Query<CompanyLocationTaxSettings>("taxSettings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationTaxSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationTaxSettings>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder TotalSpent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSpent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public CompanyLocationOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}