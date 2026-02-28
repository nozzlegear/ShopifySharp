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
    public sealed class QueryRootCompanyLocationQueryBuilder : FieldsQueryBuilderBase<CompanyLocation, QueryRootCompanyLocationQueryBuilder>, IHasArguments<QueryRootCompanyLocationArgumentsBuilder>
    {
        public QueryRootCompanyLocationArgumentsBuilder Arguments { get; }
        protected override QueryRootCompanyLocationQueryBuilder Self => this;

        public QueryRootCompanyLocationQueryBuilder(string name) : base(new Query<CompanyLocation>(name))
        {
            Arguments = new QueryRootCompanyLocationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompanyLocationQueryBuilder(IQuery<CompanyLocation> query) : base(query)
        {
            Arguments = new QueryRootCompanyLocationArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootCompanyLocationQueryBuilder SetArguments(Action<QueryRootCompanyLocationArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder BillingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder> build)
        {
            var query = new Query<CompanyAddress>("billingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyAddress>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder BuyerExperienceConfiguration(Action<ShopifySharp.GraphQL.QueryBuilders.Types.BuyerExperienceConfigurationQueryBuilder> build)
        {
            var query = new Query<BuyerExperienceConfiguration>("buyerExperienceConfiguration");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.BuyerExperienceConfigurationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BuyerExperienceConfiguration>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Catalogs(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CatalogConnectionQueryBuilder> build)
        {
            var query = new Query<CatalogConnection>("catalogs");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CatalogConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CatalogConnection>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder CatalogsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("catalogsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Company(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder> build)
        {
            var query = new Query<Company>("company");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Company>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Currency()
        {
            base.InnerQuery.AddField("currency");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder DefaultCursor()
        {
            base.InnerQuery.AddField("defaultCursor");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder DraftOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderConnectionQueryBuilder> build)
        {
            var query = new Query<DraftOrderConnection>("draftOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DraftOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderConnection>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder ExternalId()
        {
            base.InnerQuery.AddField("externalId");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder InCatalog()
        {
            base.InnerQuery.AddField("inCatalog");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Market(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder> build)
        {
            var query = new Query<Market>("market");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MarketQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Market>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        [Obsolete("Use `ordersCount` instead.")]
        public QueryRootCompanyLocationQueryBuilder OrderCount()
        {
            base.InnerQuery.AddField("orderCount");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Orders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder> build)
        {
            var query = new Query<OrderConnection>("orders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderConnection>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder OrdersCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("ordersCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder RoleAssignments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyContactRoleAssignmentConnection>("roleAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyContactRoleAssignmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyContactRoleAssignmentConnection>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder ShippingAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder> build)
        {
            var query = new Query<CompanyAddress>("shippingAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyAddress>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder StaffMemberAssignments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentConnectionQueryBuilder> build)
        {
            var query = new Query<CompanyLocationStaffMemberAssignmentConnection>("staffMemberAssignments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationStaffMemberAssignmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationStaffMemberAssignmentConnection>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder StoreCreditAccounts(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder> build)
        {
            var query = new Query<StoreCreditAccountConnection>("storeCreditAccounts");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StoreCreditAccountConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StoreCreditAccountConnection>(query);
            return this;
        }

        [Obsolete("Use `taxSettings` instead.")]
        public QueryRootCompanyLocationQueryBuilder TaxExemptions()
        {
            base.InnerQuery.AddField("taxExemptions");
            return this;
        }

        [Obsolete("Use `taxSettings` instead.")]
        public QueryRootCompanyLocationQueryBuilder TaxRegistrationId()
        {
            base.InnerQuery.AddField("taxRegistrationId");
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder TaxSettings(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationTaxSettingsQueryBuilder> build)
        {
            var query = new Query<CompanyLocationTaxSettings>("taxSettings");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CompanyLocationTaxSettingsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<CompanyLocationTaxSettings>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder TotalSpent(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder> build)
        {
            var query = new Query<MoneyV2>("totalSpent");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MoneyV2QueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MoneyV2>(query);
            return this;
        }

        public QueryRootCompanyLocationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}