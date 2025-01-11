﻿using Microsoft.AspNetCore.Mvc;
using OnlineEdu.WebUI.DTOs.SocialMediaDtos;
using OnlineEdu.WebUI.Helpers;

namespace OnlineEdu.WebUI.ViewComponents.UILayout
{
    
    public class _UILayoutSocialMediaComponent : ViewComponent
    {
        private readonly HttpClient _client = HttpClientInstance.CreateClient();
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var socialMedias = await _client.GetFromJsonAsync<List<ResultSocialMediaDto>>("socialMedias");
            return View(socialMedias);
        }
    }
}