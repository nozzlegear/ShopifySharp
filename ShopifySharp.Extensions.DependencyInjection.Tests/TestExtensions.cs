namespace ShopifySharp.Extensions.DependencyInjection.Tests
{
    public static class ObjectExtensions
    {
        private static readonly Dictionary<ServiceLifetime, bool> ServiceLifetimeInstanceValidation = new()
        {
            { ServiceLifetime.Scoped, true },
            { ServiceLifetime.Singleton, true },
            { ServiceLifetime.Transient, false }
        };

        public static bool ValidLifetimeInstance(this object actual, object expceted, ServiceLifetime serviceLifetime)
        {
            return ServiceLifetimeInstanceValidation.TryGetValue(serviceLifetime, out bool value) && value ? ReferenceEquals(actual, expceted) : !ReferenceEquals(actual, expceted);
        }
    }

    public static class ServiceProviderExtensions
    {
        public static TestServiceLifetime<T> GetServiceInstances<T>(this ServiceProvider? serviceProvider) where T : class
        {
            var service1 = serviceProvider?.GetService<T>();
            var service2 = serviceProvider?.GetService<T>();

            return new TestServiceLifetime<T>(service1, service2);
        }
    }
}
