using ShopifySharp.Services.Graph;
using ShopifySharp.GraphQL;
using ShopifySharp.Tests.Integration.Features.Products.Models;

namespace ShopifySharp.Tests.Integration.Features.Products;

[Collection("Product Queries")]
public class ProductQueryTests(VerifyFixture verifyFixture, GraphServiceFixture graphServiceFixture)
    : IClassFixture<VerifyFixture>, IClassFixture<GraphServiceFixture>
{
    private readonly VerifySettings _verifySettings = verifyFixture.Settings;
    private readonly IGraphService _sut = graphServiceFixture.Service;

    private static OptionCreateInput MakeOptionCreationInput(string optionName, string[] optionValues)
    {
        return new OptionCreateInput
        {
            name = optionName,
            values = optionValues.Select(value => new OptionValueCreateInput
            {
                name = value
            }).ToArray(),
        };
    }

    [Fact]
    public async Task ProductsQuery_ShouldListProducts()
    {
        // Setup
        var request = new GraphRequest
        {
            Query =
                """
                query getProducts($first: Int) {
                    products(first: $first) {
                        pageInfo {
                            startCursor
                            endCursor
                            hasNextPage
                            hasPreviousPage
                        }
                        nodes {
                            id
                            title
                            handle
                            description(truncateAt: 60)
                            legacyResourceId
                            publishedAt
                            status
                            variants(first: 3) {
                                pageInfo {
                                    startCursor
                                    endCursor
                                    hasNextPage
                                    hasPreviousPage
                                }
                                nodes {
                                    id
                                    availableForSale
                                    displayName
                                    sku
                                    inventoryQuantity
                                    legacyResourceId
                                    selectedOptions {
                                        name
                                        value
                                        details: optionValue {
                                            id
                                        }
                                    }
                                    image {
                                        id
                                        altText
                                        url
                                    }
                                }
                            }
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "first", 3 }
            },
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        };

        // Act
        var products = await _sut.PostAsync<GetProductsQueryResponse>(request);

        // Assert
        await Verify(products.Data.Products, _verifySettings);
    }

    [Fact]
    public async Task ProductsMutation_ShouldCreateNewProduct()
    {
        // Setup
        const string expectedTitle = "some-expected-title";
        const string expectedDescriptionHtml = "some-expected-description-html";
        const string expectedVendor = "some-expected-vendor";
        var request = new GraphRequest
        {
            Query =
                """
                mutation createProduct($title: String!, $descriptionHtml: String!, $vendor: String!) {
                    result: productCreate(product: {
                        title: $title
                        status: DRAFT
                        descriptionHtml: $descriptionHtml
                        vendor: $vendor
                    }) {
                        product {
                            description
                            hasOnlyDefaultVariant
                            id
                            options {
                                name
                                id
                                values
                                optionValues {
                                    id
                                    name
                                }
                            }
                            status
                            title
                            variantsCount {
                                count
                            }
                            vendor
                            variants(first: 10) {
                                nodes {
                                    id
                                    displayName
                                    title
                                    selectedOptions {
                                        name
                                        value
                                    }
                                }
                            }
                        }
                        userErrors {
                            field
                            message
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "title", expectedTitle },
                { "descriptionHtml", expectedDescriptionHtml },
                { "vendor", expectedVendor }
            },
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        };

        // Act
        var result = await _sut.PostAsync<CreateProductResponse>(request);

        // Assert
        result.Data.Result.Product.Should().NotBeNull();

        var product = result.Data.Result.Product;
        await Verify(product, _verifySettings);
    }

    [Fact]
    public async Task ProductsMutation_WhenTheMutationDoesNotIncludeTheProductId_ShouldThrow()
    {
        // Setup
        var request = new GraphRequest
        {
            //lang=txt
            Query =
                """
                mutation updateProductTitle {
                    result: productUpdate(product: {title: "some-new-title"}) {
                        userErrors {
                            # The id field doesn't exist here, which should cause Shopify to return an error with the request itself
                            id
                            message
                            field
                        }
                        product {
                            id
                            legacyResourceId
                            title
                        }
                    }
                }
                """
        };

        // Act
        var act = async () => await _sut.PostAsync<UpdateProductResponse>(request);

        // Assert
        var exn = await act.Should().ThrowExactlyAsync<ShopifyGraphErrorsException>();
        exn.WithMessage("undefinedField: Field 'id' doesn't exist on type 'UserError'");
        exn.And.RequestId.Should().NotBeNullOrEmpty();

        await Verify(exn.Which.GraphErrors, _verifySettings);
    }

    [Fact]
    public async Task ProductsMutation_ShouldUpdateTheProductTitle()
    {
        // Setup
        const string expectedNewTitle = "some-expected-new-title";
        var product = await CreateProductAsync("some-title");
        var request = new GraphRequest
        {
            Query =
                """
                mutation updateProductTitle($productId: ID!, $newTitle: String!) {
                    result: productUpdate(product: {id: $productId, title: $newTitle}) {
                        product {
                            id
                            title
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "productId", product.Id },
                { "newTitle", expectedNewTitle }
            }
        };

        // Act
        var result = await _sut.PostAsync<UpdateProductResponse>(request);

        // Assert
        result.Data.Result.Product.title.Should().Be(expectedNewTitle);
        result.Data.Result.Product.id.Should().Be(product.Id);

        await Verify(result.Data.Result.Product, _verifySettings);
    }

    [Fact]
    public async Task ProductsMutation_ShouldAddANewProductOption()
    {
        // Setup
        const string expectedOptionName = "some-expected-option-name";
        const string expectedOptionValue1 = "some-expected-option-value1";
        const string expectedOptionValue2 = "some-expected-option-value2";
        var product = await CreateProductAsync("some-title");
        OptionCreateInput[] newOptions =
        [
            MakeOptionCreationInput(expectedOptionName, [expectedOptionValue1, expectedOptionValue2])
        ];
        var request = new GraphRequest
        {
            Query =
                """
                mutation updateProductOptions($productId: ID!, $newOptions: [OptionCreateInput!]!) {
                    result: productOptionsCreate(productId: $productId, options: $newOptions, variantStrategy: CREATE) {
                        userErrors {
                            message
                            field
                            code
                        }
                        product {
                            id
                            title
                            options {
                                name
                                id
                                values
                                optionValues {
                                    id
                                    name
                                    hasVariants
                                }
                            }
                            variantsCount {
                                count
                            }
                            hasOnlyDefaultVariant
                            variants(first: 10) {
                                nodes {
                                    id
                                    displayName
                                    selectedOptions {
                                        name
                                        value
                                    }
                                }
                            }
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "productId", product.Id },
                { "newOptions", newOptions }
            }
        };

        // Act
        var result = await _sut.PostAsync<UpdateProductOptionsResponse>(request);
        var updatedProduct = result.Data.Result.Product;
        var updatedVariants = updatedProduct.Variants.Nodes;

        // Assert
        updatedProduct.Id.Should().Be(product.Id);
        updatedProduct.VariantsCount.Count.Should().BeGreaterThan(product.VariantsCount.Count);
        updatedProduct.Options
            .Should().HaveCount(1)
            .And.AllSatisfy(option =>
            {
                option.Name.Should().Be(expectedOptionName);
                option.Values.Should().Contain([expectedOptionValue1, expectedOptionValue2]);
            });
        updatedVariants.Should().HaveCount(2)
            .And.AllSatisfy(variant =>
            {
                variant.SelectedOptions
                    .Should().HaveCount(1)
                    .And.AllSatisfy(option =>
                    {
                        option.Name.Should().Be(expectedOptionName);
                        option.Value.Should().BeOneOf(expectedOptionValue1, expectedOptionValue2);
                    });
            });

        await Verify(result.Data.Result.Product, _verifySettings);
    }

    [Fact]
    public async Task ProductsMutation_ShouldRemoveAProductOptionAndDeleteTheVariant()
    {
        // Setup
        const string expectedOptionName1 = "some-expected-option-name1";
        const string expectedOptionName2 = "some-expected-option-name2";
        const string expectedOptionValue1 = "some-expected-option-value1";
        const string expectedOptionValue2 = "some-expected-option-value2";
        const string expectedOptionValue3 = "some-expected-option-value3";
        const string expectedOptionValue4 = "some-expected-option-value4";
        var product = await CreateProductAsync("some-title", [
            MakeOptionCreationInput(expectedOptionName1, [expectedOptionValue1, expectedOptionValue2]),
            MakeOptionCreationInput(expectedOptionName2, [expectedOptionValue3, expectedOptionValue4]),
        ]);
        // Select just Option 1 for deletion
        var optionIds = product.Options
            .Where(option => option.Name == expectedOptionName1)
            .Select(option => option.Id)
            .ToArray();
        var request = new GraphRequest
        {
            Query =
                """
                mutation deleteProductOptions($productId: ID!, $optionIds: [ID!]!) {
                    result: productOptionsDelete(productId: $productId, options: $optionIds, strategy: POSITION) {
                        userErrors {
                            message
                            field
                            code
                        }
                        product {
                            id
                            title
                            options {
                                name
                                id
                                optionValues {
                                    id
                                    name
                                    hasVariants                
                                }
                                values
                            }
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "productId", product.Id },
                { "optionIds", optionIds }
            }
        };

        // Act
        var result = await _sut.PostAsync<DeleteProductOptionsResponse>(request);
        var updatedProduct = result.Data.Result.Product;

        // Assert
        await Verify(result.Data, _verifySettings);

        updatedProduct.Id.Should().Be(product.Id);
        updatedProduct.Options
            .Should().HaveCount(1)
            .And.AllSatisfy(option =>
            {
                option.Name.Should().Be(expectedOptionName2);
                option.OptionValues.Select(value => value.Name).Should()
                    .BeEquivalentTo(expectedOptionValue3, expectedOptionValue4);
            });
        // Assert that the original product had variant options
        product.Options
            .Should().HaveCount(2)
            .And.AllSatisfy(option =>
            {
                option.Name.Should().BeOneOf(expectedOptionName1, expectedOptionName2);
                option.OptionValues.Select(value => value.Name).Should().BeSubsetOf([
                    expectedOptionValue1, expectedOptionValue2, expectedOptionValue3, expectedOptionValue4
                ]);
            });
    }

    [Fact]
    public async Task ProductsMutation_ShouldPublishTheProductToTheStorefront()
    {
        // Setup
        var product = await CreateProductAsync("some-title", status: ProductStatus.DRAFT);
        var publicationId = await CreateOrGetShopifySharpPublicationAsync();
        var request = new GraphRequest
        {
            Query =
                """
                mutation publishProduct($productId: ID!, $publicationId: ID!, $publishDate: DateTime!) {
                    productStatusUpdateResult: productUpdate(product: {id: $productId, status: ACTIVE}) {
                        userErrors {
                            message 
                            field
                        }
                        product {
                          id
                          title
                          status
                        }
                    }
                    publicationResult: publishablePublish(id: $productId, input: { publicationId: $publicationId, publishDate: $publishDate }) {
                        userErrors {
                            message 
                            field
                        }
                        product: publishable {
                            # Warning: do not use anything that refers to CurrentPublication/CurrentChannel – private apps do not have a publication or channel.
                            #publishedOnCurrentPublication
                            #publishedOnCurrentChannel
                            publishedOnPublication(publicationId: $publicationId)
                            ...on Product { 
                              id
                              title
                              status
                            }
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "productId", product.Id },
                { "publishDate", DateTimeOffset.Now },
                { "publicationId", publicationId }
            }
        };

        // Assert
        var result = await _sut.PostAsync<PublishedProductResponse>(request);
        var statusUpdateResult = result.Data.ProductStatusUpdateResult.Product;
        var publicationResult = result.Data.PublicationResult.Product;

        // Act
        await Verify(result.Data, _verifySettings);

        product.Status.Should().Be(ProductStatus.DRAFT);

        statusUpdateResult.Id.Should().Be(product.Id);
        statusUpdateResult.Title.Should().Be(product.Title);
        statusUpdateResult.Status.Should().Be(ProductStatus.ACTIVE);

        publicationResult.PublishedOnPublication.Should().BeTrue();
        publicationResult.Id.Should().Be(product.Id);
        publicationResult.Title.Should().Be(product.Title);
        publicationResult.Status.Should().Be(ProductStatus.ACTIVE);
    }

    [Fact]
    public async Task ProductsMutation_ShouldUnpublishTheProductFromTheStorefront()
    {
        // Setup
        var product = await CreateProductAsync("some-title", status: ProductStatus.ACTIVE);
        var publicationId = await CreateOrGetShopifySharpPublicationAsync();
        var request = new GraphRequest
        {
            Query =
                """
                mutation unpublishProduct($productId: ID!, $publicationId: ID!) {
                    productStatusUpdateResult: productUpdate(product: {id: $productId, status: DRAFT}) {
                        userErrors {
                            message 
                            field
                        }
                        product {
                          id
                          title
                          status
                        }
                    }
                    publicationResult: publishableUnpublish(id: $productId, input: { publicationId: $publicationId }) {
                        userErrors {
                            message 
                            field
                        }
                        product: publishable {
                            # Warning: do not use anything that refers to CurrentPublication/CurrentChannel – private apps do not have a publication or channel.
                            #publishedOnCurrentPublication
                            #publishedOnCurrentChannel
                            publishedOnPublication(publicationId: $publicationId)
                            ...on Product { 
                              id
                              title
                              status
                            }
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "productId", product.Id },
                { "publicationId", publicationId }
            }
        };

        // Assert
        var result = await _sut.PostAsync<PublishedProductResponse>(request);
        var statusUpdateResult = result.Data.ProductStatusUpdateResult.Product;
        var publicationResult = result.Data.PublicationResult.Product;

        // Act
        await Verify(result.Data, _verifySettings);

        product.Status.Should().Be(ProductStatus.ACTIVE);

        statusUpdateResult.Id.Should().Be(product.Id);
        statusUpdateResult.Title.Should().Be(product.Title);
        statusUpdateResult.Status.Should().Be(ProductStatus.DRAFT);

        publicationResult.PublishedOnPublication.Should().BeFalse();
        publicationResult.Id.Should().Be(product.Id);
        publicationResult.Title.Should().Be(product.Title);
        publicationResult.Status.Should().Be(ProductStatus.DRAFT);
    }

    private async Task<string> CreateOrGetShopifySharpPublicationAsync()
    {
        var publicationDetails = await GetShopifySharpPublicationDetailsAsync();
        if (publicationDetails is not null)
            return publicationDetails.Id;

        // Create the publication
        var request = new GraphRequest
        {
            Query =
                """
                mutation createShopifySharpPublication {
                  result: publicationCreate (input: { autoPublish: false }) { 
                    userErrors { 
                      field
                      message
                    }
                    publication { 
                      id
                    }
                  }
                }
                """
        };
        var result = await _sut.PostAsync<MutationResponse<PublicationCreatePayload>>(request);
        return result.Data.Result.publication?.id!;
    }

    // private async Task<string> CreateShopifySharpCatalogAsync()
    // {
    //     // Create the catalog
    //     var request = new GraphRequest
    //     {
    //         Query =
    //             """
    //             mutation createShopifySharpCatalog {
    //                 result: catalogCreate(input: {title: "ShopifySharp Test Catalog", status: DRAFT, context: { companyLocationIds: [] }}) {
    //                     userErrors {
    //                         field
    //                         message
    //                         code
    //                     }
    //                     catalog {
    //                         id
    //                         __typename
    //                     }
    //                 }
    //             }
    //             """,
    //     };
    //     var createCatalogResult = await _sut.PostAsync<MutationResponse<CatalogCreatePayload>>(request);
    //     var catalogId = createCatalogResult.Data.Result.catalog?.id!;
    //     return catalogId;
    // }

    private async Task<ShopifySharpPublication?> GetShopifySharpPublicationDetailsAsync()
    {
        var request = new GraphRequest
        {
            Query =
                """
                query {
                    result: publications(first: 10) {
                        nodes {
                            id
                            supportsFuturePublishing
                        }
                    }
                }
                """
        };
        var result = await _sut.PostAsync<PublicationsQuery>(request);
        return result.Data.Result.Nodes.FirstOrDefault(publication => publication.SupportsFuturePublishing);
    }

    private async Task<CreatedProduct> CreateProductAsync(string title, OptionCreateInput[]? productOptions = null,
        ProductStatus status = ProductStatus.DRAFT)
    {
        var request = new GraphRequest
        {
            Query =
                """
                mutation createProduct($title: String!, $productOptions: [OptionCreateInput!], $status: ProductStatus) {
                    result: productCreate(product: {
                        title: $title
                        status: $status
                        descriptionHtml: "some-description-html"
                        vendor: "shopifysharp",
                        productOptions: $productOptions
                    }) {
                        product {
                            description
                            hasOnlyDefaultVariant
                            id
                            options {
                                name
                                id
                                optionValues {
                                    id
                                    name
                                    hasVariants
                                }
                                values
                            }
                            status
                            title
                            variantsCount {
                                count
                            }
                            vendor
                            variants(first: 10) {
                                nodes {
                                    id
                                    displayName
                                    title
                                    selectedOptions {
                                        name
                                        value
                                    }
                                }
                            }
                        }
                        userErrors {
                            field
                            message
                        }
                    }
                }
                """,
            Variables = new Dictionary<string, object>
            {
                { "title", title },
                { "productOptions", productOptions! },
                { "status", status }
            },
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        };
        var result = await _sut.PostAsync<CreateProductResponse>(request);
        return result.Data.Result.Product;
    }
}
