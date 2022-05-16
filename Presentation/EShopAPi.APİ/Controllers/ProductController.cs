using System.Diagnostics;
using EShopAPİ.Application.Repositories;
using EShopAPİ.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EShopAPi.APİ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductrWriteRepository _productWriteRepository;
        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public ProductController(IProductReadRepository productReadRepository,
            IProductrWriteRepository productWriteRepository,
            IOrderWriteRepository orderWriteRepository,
            ICustomerWriteRepository customerWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
        }

        [HttpGet]
        [Route("/datayazdir")]
        public async Task Get()
        {
            var id = Guid.NewGuid();
            await _customerWriteRepository.AddAsync(new() {İD = id, Name = "cavid"});
            await _orderWriteRepository.AddAsync(new()
                {Address = "Azerbaijan ,Baki", Description = "testin", CustomerId = id});
            await _orderWriteRepository.AddAsync(new()
                {Address = "Azerbaijan ,Baki", Description = "testin", CustomerId = id});
            await _orderWriteRepository.AddAsync(new()
                {Address = "Azerbaijan ,Baki", Description = "testin", CustomerId = id});
            await _orderWriteRepository.SaveAsync();
        }


        // [HttpGet]
        // [Route("/datayazdir")]
        // public async Task Get()
        // {
        //     await _productWriteRepository
        //         .AddAsync(
        //             new()
        //             {
        //                 Name = "testpr",
        //                 Price = 4.5f,
        //                 Stock = 25,
        //                 CreatedDate = DateTime.Now
        //             }
        //         );
        //     await _productWriteRepository.SaveAsync();
        // }

        // [HttpGet]
        // public async Task<Product> Get()
        // {
        //     Stopwatch s = new Stopwatch();
        //     s.Start();
        //     var product = await _productReadRepository
        //         .GetByIdAsync("41270906-c9e5-4759-ad08-96660e0b6898");
        //     s.Stop();
        //     var c = s.Elapsed;
        //     Console.WriteLine(c);
        //     
        //     // product.Name = "ddddd";
        //     // await _productWriteRepository.SaveAsync();
        //     return product;
        // }
        //
        // [HttpGet("{id}")]
        // public async Task<Product> Get(string id)
        // {
        //     return await _productReadRepository.GetByIdAsync(id);
        // }

        // [HttpPost]
        // public async Task<IActionResult> Post(string s)
        // {
        //     _productWriteRepository
        //         .AddRangeAsync(new()
        //         {
        //             new Product
        //             {
        //                 İD = Guid.NewGuid(), Name = "product1", Price = 25, Stock = 45, CreatedDate = DateTime.Now
        //             },
        //             new Product
        //             {
        //                 İD = Guid.NewGuid(), Name = "product2", Price = 25, Stock = 45, CreatedDate = DateTime.Now
        //             },
        //             new Product
        //             {
        //                 İD = Guid.NewGuid(), Name = "product3", Price = 25, Stock = 45, CreatedDate = DateTime.Now
        //             },
        //             new Product
        //             {
        //                 İD = Guid.NewGuid(), Name = "product4", Price = 25, Stock = 45, CreatedDate = DateTime.Now
        //             },
        //             new Product
        //             {
        //                 İD = Guid.NewGuid(), Name = "product5", Price = 25, Stock = 45, CreatedDate = DateTime.Now
        //             }
        //         });
        //     await _productWriteRepository.SaveAsync();
        //     return Ok();
        // }
    }
}