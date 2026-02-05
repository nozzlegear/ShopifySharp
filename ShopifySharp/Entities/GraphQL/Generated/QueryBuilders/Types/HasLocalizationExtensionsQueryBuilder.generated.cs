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
    public sealed class HasLocalizationExtensionsQueryBuilder : FieldsQueryBuilderBase<IHasLocalizationExtensions, HasLocalizationExtensionsQueryBuilder>
    {
        protected override HasLocalizationExtensionsQueryBuilder Self => this;

        public HasLocalizationExtensionsQueryBuilder() : this("hasLocalizationExtensions")
        {
        }

        public HasLocalizationExtensionsQueryBuilder(string name) : base(new Query<IHasLocalizationExtensions>(name))
        {
        }

        public HasLocalizationExtensionsQueryBuilder(IQuery<IHasLocalizationExtensions> query) : base(query)
        {
        }

        public HasLocalizationExtensionsQueryBuilder LocalizationExtensions(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder> build)
        {
            var query = new Query<LocalizationExtensionConnection>("localizationExtensions");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocalizationExtensionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocalizationExtensionConnection>(query);
            return this;
        }
    }
}