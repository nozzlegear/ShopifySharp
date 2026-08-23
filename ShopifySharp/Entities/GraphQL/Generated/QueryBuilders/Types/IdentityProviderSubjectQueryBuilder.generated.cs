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
    public sealed class IdentityProviderSubjectQueryBuilder : FieldsQueryBuilderBase<IdentityProviderSubject, IdentityProviderSubjectQueryBuilder>
    {
        protected override IdentityProviderSubjectQueryBuilder Self => this;

        public IdentityProviderSubjectQueryBuilder() : this("identityProviderSubject")
        {
        }

        public IdentityProviderSubjectQueryBuilder(string name) : base(new Query<IdentityProviderSubject>(name))
        {
        }

        public IdentityProviderSubjectQueryBuilder(IQuery<IdentityProviderSubject> query) : base(query)
        {
        }

        public IdentityProviderSubjectQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public IdentityProviderSubjectQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public IdentityProviderSubjectQueryBuilder ProviderName()
        {
            base.InnerQuery.AddField("providerName");
            return this;
        }

        public IdentityProviderSubjectQueryBuilder Subject()
        {
            base.InnerQuery.AddField("subject");
            return this;
        }

        public IdentityProviderSubjectQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}