using JetBrains.Annotations;
using ShopifySharp.GraphQL;
using ShopifySharp.Services.Graph;

namespace ShopifySharp.Tests.Integration;

/// <summary>
/// Fixture that tracks test products created during integration tests and cleans them up when disposed.
/// This ensures tests are isolated and don't leave test data in the Shopify store.
/// </summary>
[UsedImplicitly]
public class ProductCleanupFixture : IDisposable
{
    private readonly IGraphService _service;
    private readonly HashSet<string> _testProductIds = new();
    private bool _disposed;

    public ProductCleanupFixture()
    {
        var graphServiceFixture = new GraphServiceFixture();
        _service = graphServiceFixture.Service ?? throw new ArgumentNullException(nameof(graphServiceFixture.Service));
    }

    /// <summary>
    /// Registers a test product ID for cleanup when the fixture is disposed.
    /// </summary>
    /// <param name="productId">The Shopify product ID to clean up.</param>
    public void RegisterTestProduct(string productId)
    {
        if (string.IsNullOrWhiteSpace(productId))
        {
            throw new ArgumentException("Product ID cannot be null or empty", nameof(productId));
        }

        lock (_testProductIds)
        {
            _testProductIds.Add(productId);
        }
    }

    /// <summary>
    /// Cleans up all registered test products.
    /// </summary>
    /// <returns>A task representing the asynchronous cleanup operation.</returns>
    public async Task CleanupTestProductsAsync()
    {
        if (_disposed)
        {
            return;
        }

        List<string> productIdsToCleanup;

        lock (_testProductIds)
        {
            productIdsToCleanup = new List<string>(_testProductIds);
            _testProductIds.Clear();
        }

        if (productIdsToCleanup.Count == 0)
        {
            return;
        }

        // Delete products in batches to avoid hitting API limits
        const int batchSize = 250;
        for (int i = 0; i < productIdsToCleanup.Count; i += batchSize)
        {
            var batch = productIdsToCleanup.Skip(i).Take(batchSize).ToList();
            
            try
            {
                // Shopify GraphQL doesn't support bulk deletions directly, so we delete one by one
                foreach (var productId in batch)
                {
                    try
                    {
                        var request = new GraphRequest
                        {
                            Query = """
                            mutation productDelete($id: ID!) {
                                productDelete(input: {id: $id}) {
                                    deletedProductId
                                    userErrors {
                                        field
                                        message
                                    }
                                }
                            }
                            """,
                            Variables = new Dictionary<string, object>
                            {
                                { "id", productId }
                            }
                        };
                        await _service.PostAsync<ProductDeletePayload>(request);
                    }
                    catch (Exception ex) when (ex is not OperationCanceledException)
                    {
                        // Log but don't fail the cleanup if a product is already deleted
                        Console.Error.WriteLine($"Warning: Failed to delete test product {productId}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Warning: Failed to cleanup batch of test products: {ex.Message}");
            }
        }
    }

    /// <summary>
    /// Disposes the fixture and cleans up any remaining test products.
    /// </summary>
    public void Dispose()
    {
        if (_disposed)
        {
            return;
        }

        CleanupTestProductsAsync().GetAwaiter().GetResult();
        _disposed = true;
        GC.SuppressFinalize(this);
    }

    ~ProductCleanupFixture()
    {
        Dispose();
    }
}
