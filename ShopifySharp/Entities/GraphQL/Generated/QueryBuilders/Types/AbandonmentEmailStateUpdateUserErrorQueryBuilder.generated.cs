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
    public sealed class AbandonmentEmailStateUpdateUserErrorQueryBuilder : FieldsQueryBuilderBase<AbandonmentEmailStateUpdateUserError, AbandonmentEmailStateUpdateUserErrorQueryBuilder>
    {
        protected override AbandonmentEmailStateUpdateUserErrorQueryBuilder Self => this;

        public AbandonmentEmailStateUpdateUserErrorQueryBuilder() : this("abandonmentEmailStateUpdateUserError")
        {
        }

        public AbandonmentEmailStateUpdateUserErrorQueryBuilder(string name) : base(new Query<AbandonmentEmailStateUpdateUserError>(name))
        {
        }

        public AbandonmentEmailStateUpdateUserErrorQueryBuilder(IQuery<AbandonmentEmailStateUpdateUserError> query) : base(query)
        {
        }

        public AbandonmentEmailStateUpdateUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public AbandonmentEmailStateUpdateUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public AbandonmentEmailStateUpdateUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}