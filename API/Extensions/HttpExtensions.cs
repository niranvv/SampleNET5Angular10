using System.Text.Json;
using API.Helpers;
using Microsoft.AspNetCore.Http;

namespace API.Extensions
{
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse response,
                                               int currentPage,
                                               int itemsPerPage,
                                               int totalItems,
                                               int TotalPages)
        {
            var paginationHeader=new PaginationHeader(currentPage,itemsPerPage,totalItems,TotalPages);
            var jsonOptions=new JsonSerializerOptions{
                PropertyNamingPolicy=JsonNamingPolicy.CamelCase
            };
            response.Headers.Add("Pagination",JsonSerializer.Serialize(paginationHeader,jsonOptions));
            response.Headers.Add("Access-Control-Expose-Headers","Pagination");
        }
        
    }
}