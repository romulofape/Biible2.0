using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace BiibleApi.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static void AddPagination(this HttpResponse response,
            int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            PaginationHeader paginationHeader = new PaginationHeader(currentPage, itemsPerPage, totalItems, totalPages);
            JsonSerializerSettings camelCaseFormatter = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            response.Headers.Add("Pagination",
                JsonConvert.SerializeObject(paginationHeader, camelCaseFormatter));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }

        public static int CalculateAge(this DateTime theDateTime)
        {
            int age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.AddYears(age) > DateTime.Today)
            {
                age--;
            }

            return age;
        }
    }
}