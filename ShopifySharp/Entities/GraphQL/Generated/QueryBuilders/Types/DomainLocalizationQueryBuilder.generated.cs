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
    public sealed class DomainLocalizationQueryBuilder : FieldsQueryBuilderBase<DomainLocalization, DomainLocalizationQueryBuilder>
    {
        protected override DomainLocalizationQueryBuilder Self => this;

        public DomainLocalizationQueryBuilder() : this("domainLocalization")
        {
        }

        public DomainLocalizationQueryBuilder(string name) : base(new Query<DomainLocalization>(name))
        {
        }

        public DomainLocalizationQueryBuilder(IQuery<DomainLocalization> query) : base(query)
        {
        }

        public DomainLocalizationQueryBuilder AlternateLocales()
        {
            base.InnerQuery.AddField("alternateLocales");
            return this;
        }

        public DomainLocalizationQueryBuilder Country()
        {
            base.InnerQuery.AddField("country");
            return this;
        }

        public DomainLocalizationQueryBuilder DefaultLocale()
        {
            base.InnerQuery.AddField("defaultLocale");
            return this;
        }
    }
}