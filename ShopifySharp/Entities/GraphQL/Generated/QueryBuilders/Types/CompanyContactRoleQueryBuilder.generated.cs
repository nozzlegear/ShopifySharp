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
    public sealed class CompanyContactRoleQueryBuilder : FieldsQueryBuilderBase<CompanyContactRole, CompanyContactRoleQueryBuilder>
    {
        protected override CompanyContactRoleQueryBuilder Self => this;

        public CompanyContactRoleQueryBuilder() : this("companyContactRole")
        {
        }

        public CompanyContactRoleQueryBuilder(string name) : base(new Query<CompanyContactRole>(name))
        {
        }

        public CompanyContactRoleQueryBuilder(IQuery<CompanyContactRole> query) : base(query)
        {
        }

        public CompanyContactRoleQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CompanyContactRoleQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CompanyContactRoleQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }
    }
}