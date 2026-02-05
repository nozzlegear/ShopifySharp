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
    public sealed class StaffMemberQueryBuilder : FieldsQueryBuilderBase<StaffMember, StaffMemberQueryBuilder>
    {
        protected override StaffMemberQueryBuilder Self => this;

        public StaffMemberQueryBuilder() : this("staffMember")
        {
        }

        public StaffMemberQueryBuilder(string name) : base(new Query<StaffMember>(name))
        {
        }

        public StaffMemberQueryBuilder(IQuery<StaffMember> query) : base(query)
        {
        }

        public StaffMemberQueryBuilder AccountType()
        {
            base.InnerQuery.AddField("accountType");
            return this;
        }

        public StaffMemberQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public StaffMemberQueryBuilder Avatar(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("avatar");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public StaffMemberQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public StaffMemberQueryBuilder Exists()
        {
            base.InnerQuery.AddField("exists");
            return this;
        }

        public StaffMemberQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public StaffMemberQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public StaffMemberQueryBuilder Initials()
        {
            base.InnerQuery.AddField("initials");
            return this;
        }

        public StaffMemberQueryBuilder IsShopOwner()
        {
            base.InnerQuery.AddField("isShopOwner");
            return this;
        }

        public StaffMemberQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public StaffMemberQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public StaffMemberQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public StaffMemberQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public StaffMemberQueryBuilder PrivateData(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberPrivateDataQueryBuilder> build)
        {
            var query = new Query<StaffMemberPrivateData>("privateData");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberPrivateDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberPrivateData>(query);
            return this;
        }
    }
}