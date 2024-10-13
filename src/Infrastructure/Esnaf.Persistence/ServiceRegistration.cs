using Esnaf.Application.Abstractions.Services;
using Esnaf.Application.Repositories;
using Esnaf.Persistence.Repositories;
using Esnaf.Persistence.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Esnaf.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            #region Repositories
            services.AddScoped<IAddressReadRepository, AddressReadRepository>();
            services.AddScoped<IAddressWriteRepository, AddressWriteRepository>();
            services.AddScoped<ICartReadRepository, CartReadRepository>();
            services.AddScoped<ICartWriteRepository, CartWriteRepository>();
            services.AddScoped<ICartItemReadRepository, CartItemReadRepository>();
            services.AddScoped<ICartItemWriteRepository, CartItemWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IOrderDetailReadRepository, OrderDetailReadRepository>();
            services.AddScoped<IOrderDetailWriteRepository, OrderDetailWriteRepository>();
            services.AddScoped<IPaymentReadRepository, IPaymentReadRepository>();
            services.AddScoped<IPaymentWriteRepository, IPaymentWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductPriceReadRepository, ProductPricesReadRepository>();
            services.AddScoped<IProductPriceWriteRepository, ProductPricesWriteRepository>();
            services.AddScoped<ISellerReadRepository,ISellerReadRepository>();
            services.AddScoped<ISellerWriteRepository,ISellerWriteRepository>();
            #endregion


            #region Services

            #endregion

        }
    }
}
