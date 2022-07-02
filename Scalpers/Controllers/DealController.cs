using Microsoft.AspNetCore.Mvc;
using Scalpers.Models;
using Scalpers.Services;

namespace Scalpers.Controllers
{
    public class DealController : Controller
    {
        public IActionResult Deal()
        {
            DealModel model = new DealModel();
            return View(model);
        }

        public async Task<IActionResult> StartNewDeal(int botId)
        {
            ExternalService service = new ExternalService();
            var result = await service.StartNewDealAsync(botId);
            DealModel model = new DealModel();

            if(result == null)
            {
                model.Error = "Something went wrong while creating a new deal. Please try again later.";
            }

            model.IsSuccess  = result.IsSuccess;
            model.Error = result.Error;

            return View("Deal", model);
        }
    }
}
