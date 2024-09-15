using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.MessageDtos;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]

    public class MessageController : Controller
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IActionResult> Index()
        {
            var values = await _client.GetFromJsonAsync<List<ResultMessageDto>>("messages");
            return View(values);
        }
        public async Task<IActionResult> DeleteMessage(int id)
        {
            await _client.DeleteAsync($"messages/{id}");
            return RedirectToAction(nameof(Index));
        }
      
        public async Task<IActionResult> MessageDetail(int id)
        {
            var value = await _client.GetFromJsonAsync<ResultMessageDto>($"messages/{id}");
            return View(value);
        }
    }
}
