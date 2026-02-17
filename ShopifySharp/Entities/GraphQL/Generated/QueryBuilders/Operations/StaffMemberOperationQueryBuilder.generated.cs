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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class StaffMemberOperationQueryBuilder : FieldsQueryBuilderBase<StaffMember, StaffMemberOperationQueryBuilder>, IGraphOperationQueryBuilder<StaffMember>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public StaffMemberArgumentsBuilder Arguments { get; }
        protected override StaffMemberOperationQueryBuilder Self => this;

        public StaffMemberOperationQueryBuilder() : this("staffMember")
        {
        }

        public StaffMemberOperationQueryBuilder(string name) : base(new Query<StaffMember>(name))
        {
            Arguments = new StaffMemberArgumentsBuilder(base.InnerQuery);
        }

        public StaffMemberOperationQueryBuilder(IQuery<StaffMember> query) : base(query)
        {
            Arguments = new StaffMemberArgumentsBuilder(base.InnerQuery);
        }

        public StaffMemberOperationQueryBuilder AccountType()
        {
            base.InnerQuery.AddField("accountType");
            return this;
        }

        public StaffMemberOperationQueryBuilder Active()
        {
            base.InnerQuery.AddField("active");
            return this;
        }

        public StaffMemberOperationQueryBuilder Avatar(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder> build)
        {
            var query = new Query<Image>("avatar");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ImageQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Image>(query);
            return this;
        }

        public StaffMemberOperationQueryBuilder Email()
        {
            base.InnerQuery.AddField("email");
            return this;
        }

        public StaffMemberOperationQueryBuilder Exists()
        {
            base.InnerQuery.AddField("exists");
            return this;
        }

        public StaffMemberOperationQueryBuilder FirstName()
        {
            base.InnerQuery.AddField("firstName");
            return this;
        }

        public StaffMemberOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public StaffMemberOperationQueryBuilder Initials()
        {
            base.InnerQuery.AddField("initials");
            return this;
        }

        public StaffMemberOperationQueryBuilder IsShopOwner()
        {
            base.InnerQuery.AddField("isShopOwner");
            return this;
        }

        public StaffMemberOperationQueryBuilder LastName()
        {
            base.InnerQuery.AddField("lastName");
            return this;
        }

        public StaffMemberOperationQueryBuilder Locale()
        {
            base.InnerQuery.AddField("locale");
            return this;
        }

        public StaffMemberOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public StaffMemberOperationQueryBuilder Phone()
        {
            base.InnerQuery.AddField("phone");
            return this;
        }

        public StaffMemberOperationQueryBuilder PrivateData(Action<ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberPrivateDataQueryBuilder> build)
        {
            var query = new Query<StaffMemberPrivateData>("privateData");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.StaffMemberPrivateDataQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<StaffMemberPrivateData>(query);
            return this;
        }
    }
}