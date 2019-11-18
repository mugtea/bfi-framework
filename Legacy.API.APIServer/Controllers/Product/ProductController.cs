using AutoMapper;
using BFICommon.Core;
using Legacy.Entities.Product;
using Legacy.Transaction.Controller.Product;
using Legacy.Transaction.Request.Product;
using Legacy.View.Controller.Product;
using Legacy.View.Request.Product;
using Legacy.View.Response.Product;
using Legacy.View.ViewException;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Legacy.API.APIServer.Controllers.Product
{
    [Route("api/v1/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        BaseJsonResponse baseJsonResponse = new BaseJsonResponse();
        ProductViewController productViewController = new ProductViewController();
        ProductTransactionController productTransactionController = new ProductTransactionController();

        [Route("get")]
        [HttpGet]
        public IActionResult Get([FromQuery] PaggingRequest productViewRequest)
        {
            PaggingRequestEntities productRequestEntities = Mapper.Map<PaggingRequest, PaggingRequestEntities>(productViewRequest);
            List<ProductViewResponse> productViewEntities = Mapper.Map<List<ProductResponseEntities>, List<ProductViewResponse>>(productViewController.GetProduct(productRequestEntities));
            baseJsonResponse.Data = productViewEntities ?? throw new DataNotExistException();
            return Ok(baseJsonResponse);
        }

        [Route("add")]
        [HttpPost]
        public IActionResult AddProduct(AddProductTransactionRequest productTransactionRequest)
        {
            AddProductRequestEntities productRequestEntities = Mapper.Map<AddProductTransactionRequest, AddProductRequestEntities>(productTransactionRequest);
            string result = productTransactionController.AddProduct(productRequestEntities);
            baseJsonResponse.Data = result;
            return Ok(baseJsonResponse);
        }

        [Route("update")]
        [HttpPost]
        public IActionResult UpdateProduct(EditProductTransactionRequest productTransactionRequest)
        {
            EditProductRequestEntities productRequestEntities = Mapper.Map<EditProductTransactionRequest, EditProductRequestEntities>(productTransactionRequest);
            string result = productTransactionController.UpdateProduct(productRequestEntities);
            baseJsonResponse.Data = result;
            return Ok(baseJsonResponse);
        }

        [Route("delete")]
        [HttpPost]
        public IActionResult DeleteProduct(DeleteProductTransactionRequest productTransactionRequest)
        {
            
            DeleteProductRequestEntities productRequestEntities = Mapper.Map<DeleteProductTransactionRequest, DeleteProductRequestEntities>(productTransactionRequest);
            string result = productTransactionController.DeleteProduct(productRequestEntities);
            baseJsonResponse.Data = result;
            return Ok(baseJsonResponse);
        }
    }
}