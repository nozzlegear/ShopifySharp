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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CurrentStaffMemberOperationQueryBuilder : FieldsQueryBuilderBase<StaffMember, CurrentStaffMemberOperationQueryBuilder>, IGraphOperationQueryBuilder<StaffMember>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        protected override CurrentStaffMemberOperationQueryBuilder Self => this;

        public CurrentStaffMemberOperationQueryBuilder() : this("currentStaffMember")
        {
        }

        public CurrentStaffMemberOperationQueryBuilder(string name) : base(new Query<StaffMember>(name))
        {
        }

        public CurrentStaffMemberOperationQueryBuilder(IQuery<StaffMember> query) : base(query)
        {
        }

        public CurrentStaffMemberOperationQueryBuilder AccountType()
        {
            base.InnerQuery.AddField("accountType");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Avatar(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("avatar");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Exists()
        {
            base.InnerQuery.AddField("exists");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Initials()
        {
            base.InnerQuery.AddField("initials");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder IsShopOwner()
        {
            base.InnerQuery.AddField("isShopOwner");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public CurrentStaffMemberOperationQueryBuilder PrivateData(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberPrivateDataQueryBuilder> build)
        {
            var query = new Query<StaffMemberPrivateData>("privateData");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.StaffMemberPrivateDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberPrivateData>(query);
            return this;
        }
    }
}