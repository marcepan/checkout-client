using Checkout.ApiServices.Drinks.RequestModels;
using Checkout.ApiServices.Drinks.ResponseModels;
using Checkout.ApiServices.SharedModels;

namespace Checkout.ApiServices.Drinks
{
    public class DrinkService
    {
        public HttpResponse<Drink> CreateDrink(DrinkCreate requestModel)
        {
            var createDrinkUri = ApiUrls.Drinks;
            return new ApiHttpClient().PostRequest<Drink>(createDrinkUri, AppSettings.SecretKey, requestModel);
        }

        public HttpResponse<Drink> GetDrink(string drinkName)
        {
            var getDrinkUri = string.Format(ApiUrls.Drink, drinkName);
            return new ApiHttpClient().GetRequest<Drink>(getDrinkUri, AppSettings.SecretKey);
        }

        public HttpResponse<OkResponse> UpdateDrink(string drinkName, DrinkUpdate requestModel)
        {
            var updateDrinkUri = string.Format(ApiUrls.Drink, drinkName);
            return new ApiHttpClient().PutRequest<OkResponse>(updateDrinkUri, AppSettings.SecretKey, requestModel);
        }

        public HttpResponse<OkResponse> DeleteDrink(string drinkName)
        {
            var deleteDrinkUri = string.Format(ApiUrls.Drink, drinkName);
            return new ApiHttpClient().DeleteRequest<OkResponse>(deleteDrinkUri, AppSettings.SecretKey);
        }

        public HttpResponse<DrinkList> GetDrinkList()
        {
            var getDrinkListUri = ApiUrls.Drinks;
            return new ApiHttpClient().GetRequest<DrinkList>(getDrinkListUri, AppSettings.SecretKey);
        }
    }
}
