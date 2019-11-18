using AutoMapper;
using Legacy.Entities.Product;
using Legacy.Transaction.Request.Product;
using Legacy.View.Request.Product;
using Legacy.View.Response.Product;

namespace Legacy.API.APIServer.Utilities.AutoMapper

{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<PaggingRequest, PaggingRequestEntities>();
            CreateMap<AddProductTransactionRequest, AddProductRequestEntities>();
            CreateMap<EditProductTransactionRequest, EditProductRequestEntities>();
            CreateMap<DeleteProductTransactionRequest , DeleteProductRequestEntities>();
            CreateMap<ProductResponseEntities, ProductViewResponse>();
            CreateMap<ProductTransactionRequest, PaggingRequestEntities>();
        }
    }
}