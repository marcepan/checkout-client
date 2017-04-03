using Environment = Checkout.Helpers.Environment;

namespace Checkout.ApiClient.Net45.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new APIClient(
                "Bearer LVo-8owH2-tPqhfStQutogS6mItUlQu-8BbNqiG8SpfHmKRR1rH4p7Wy7-nkgY7CsY9zZtJOyAdf4rZaKQ6zqHEJ_GyLElGA8M_kIoILyGdCJOwOGxAqpLw0IjufYTnKjPFne6QJOa3ROTyDp1Y-IaJ8diliUdH91oYgI-3hgMufAU8YvcfG8j_skzkGld7wxxVyd1yUxT59yQgXARS1QbWhBITGnZG3I8m8qL2rtGk",
                Environment.Sandbox,
                true);
            client.DrinkService.GetDrinkList();
            System.Console.ReadKey();
        }
    }
}
