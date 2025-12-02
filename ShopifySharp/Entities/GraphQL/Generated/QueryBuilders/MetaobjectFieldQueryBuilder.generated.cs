#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class MetaobjectFieldQueryBuilder() : GraphQueryBuilder<MetaobjectField>("metaobjectField")
{
    public MetaobjectFieldQueryBuilder AddFieldDefinition(Func<MetaobjectFieldDefinitionQueryBuilder, MetaobjectFieldDefinitionQueryBuilder> build)
    {
        AddField<MetaobjectFieldDefinition, MetaobjectFieldDefinitionQueryBuilder>("definition", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldJsonValue()
    {
        AddField("jsonValue");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<CollectionQueryBuilder, CollectionQueryBuilder> build)
    {
        AddUnion<Collection, CollectionQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<CompanyQueryBuilder, CompanyQueryBuilder> build)
    {
        AddUnion<Company, CompanyQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddUnion<Customer, CustomerQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<GenericFileQueryBuilder, GenericFileQueryBuilder> build)
    {
        AddUnion<GenericFile, GenericFileQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<MediaImageQueryBuilder, MediaImageQueryBuilder> build)
    {
        AddUnion<MediaImage, MediaImageQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<MetaobjectQueryBuilder, MetaobjectQueryBuilder> build)
    {
        AddUnion<Metaobject, MetaobjectQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<Model3dQueryBuilder, Model3dQueryBuilder> build)
    {
        AddUnion<Model3d, Model3dQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddUnion<Order, OrderQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<PageQueryBuilder, PageQueryBuilder> build)
    {
        AddUnion<Page, PageQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddUnion<Product, ProductQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddUnion<ProductVariant, ProductVariantQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<TaxonomyValueQueryBuilder, TaxonomyValueQueryBuilder> build)
    {
        AddUnion<TaxonomyValue, TaxonomyValueQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddUnionCaseReference(Func<VideoQueryBuilder, VideoQueryBuilder> build)
    {
        AddUnion<Video, VideoQueryBuilder>("reference", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldReferences(Func<MetafieldReferenceConnectionQueryBuilder, MetafieldReferenceConnectionQueryBuilder> build)
    {
        AddField<MetafieldReferenceConnection, MetafieldReferenceConnectionQueryBuilder>("references", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldThumbnail(Func<MetaobjectThumbnailQueryBuilder, MetaobjectThumbnailQueryBuilder> build)
    {
        AddField<MetaobjectThumbnail, MetaobjectThumbnailQueryBuilder>("thumbnail", build);
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public MetaobjectFieldQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}