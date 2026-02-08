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
    public sealed class CombinedListingUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<CombinedListingUpdateUserError, CombinedListingUpdateUserErrorQueryBuilder>
    {
        protected override CombinedListingUpdateUserErrorQueryBuilder Self => this;

        public CombinedListingUpdateUserErrorQueryBuilder() : this("combinedListingUpdateUserError")
        {
        }

        public CombinedListingUpdateUserErrorQueryBuilder(string name) : base(new Query<CombinedListingUpdateUserError>(name))
        {
        }

        public CombinedListingUpdateUserErrorQueryBuilder(IQuery<CombinedListingUpdateUserError> query) : base(query)
        {
        }

        public CombinedListingUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public CombinedListingUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public CombinedListingUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}