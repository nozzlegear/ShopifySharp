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
    public sealed class QueryRootStaffMemberQueryBuilder : FieldsQueryBuilderBase<StaffMember, QueryRootStaffMemberQueryBuilder>, IHasArguments<QueryRootStaffMemberArgumentsBuilder>
    {
        public QueryRootStaffMemberArgumentsBuilder Arguments { get; }
        protected override QueryRootStaffMemberQueryBuilder Self => this;

        public QueryRootStaffMemberQueryBuilder(string name) : base(new Query<StaffMember>(name))
        {
            Arguments = new QueryRootStaffMemberArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootStaffMemberQueryBuilder(IQuery<StaffMember> query) : base(query)
        {
            Arguments = new QueryRootStaffMemberArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootStaffMemberQueryBuilder SetArguments(Action<QueryRootStaffMemberArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootStaffMemberQueryBuilder AccountType()
        {
            base.InnerQuery.AddField("accountType");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Avatar(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("avatar");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Exists()
        {
            base.InnerQuery.AddField("exists");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Initials()
        {
            base.InnerQuery.AddField("initials");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder IsShopOwner()
        {
            base.InnerQuery.AddField("isShopOwner");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public QueryRootStaffMemberQueryBuilder PrivateData(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberPrivateDataQueryBuilder> build)
        {
            var query = new Query<StaffMemberPrivateData>("privateData");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberPrivateDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberPrivateData>(query);
            return this;
        }
    }
}