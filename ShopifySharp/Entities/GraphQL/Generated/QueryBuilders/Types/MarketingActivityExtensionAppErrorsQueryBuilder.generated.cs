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
    public sealed class MarketingActivityExtensionAppErrorsQueryBuilder : FieldsQueryBuilderBase<MarketingActivityExtensionAppErrors, MarketingActivityExtensionAppErrorsQueryBuilder>
    {
        protected override MarketingActivityExtensionAppErrorsQueryBuilder Self => this;

        public MarketingActivityExtensionAppErrorsQueryBuilder() : this("marketingActivityExtensionAppErrors")
        {
        }

        public MarketingActivityExtensionAppErrorsQueryBuilder(string name) : base(new Query<MarketingActivityExtensionAppErrors>(name))
        {
        }

        public MarketingActivityExtensionAppErrorsQueryBuilder(IQuery<MarketingActivityExtensionAppErrors> query) : base(query)
        {
        }

        public MarketingActivityExtensionAppErrorsQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public MarketingActivityExtensionAppErrorsQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }
    }
}