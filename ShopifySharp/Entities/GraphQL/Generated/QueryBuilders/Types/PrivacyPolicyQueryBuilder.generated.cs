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
    public sealed class PrivacyPolicyQueryBuilder : FieldsQueryBuilderBase<PrivacyPolicy, PrivacyPolicyQueryBuilder>
    {
        protected override PrivacyPolicyQueryBuilder Self => this;

        public PrivacyPolicyQueryBuilder() : this("privacyPolicy")
        {
        }

        public PrivacyPolicyQueryBuilder(string name) : base(new Query<PrivacyPolicy>(name))
        {
        }

        public PrivacyPolicyQueryBuilder(IQuery<PrivacyPolicy> query) : base(query)
        {
        }

        public PrivacyPolicyQueryBuilder AutoManaged()
        {
            base.InnerQuery.AddField("autoManaged");
            return this;
        }

        public PrivacyPolicyQueryBuilder SupportedLocales()
        {
            base.InnerQuery.AddField("supportedLocales");
            return this;
        }
    }
}