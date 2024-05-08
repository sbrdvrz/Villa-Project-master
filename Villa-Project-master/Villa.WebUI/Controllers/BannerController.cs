using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Businnes.Abstrack;
using Villa.DTO.Dtos.BannerDtos;
using Villa.Entities.Concrete;

namespace Villa.WebUI.Controllers
{
    public class BannerController : Controller
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public BannerController(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _bannerService.TGetListAsync();
            var bannerList = _mapper.Map<List<ResultBannerDto>>(value);
            return View(bannerList);
        }
        public async Task<IActionResult> DeleteBanner(ObjectId id)
        {
            await _bannerService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateBanner()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto createBanner)
        {
            var newBanner = _mapper.Map<Banner>(createBanner);
            await _bannerService.TCreateAsync(newBanner);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateBanner(ObjectId id)
        {
            var value = await _bannerService.TGetByIdAsync(id);
            var mapUpdate = _mapper.Map<UpdateBannerDto>(value);
            return View(mapUpdate);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBanner)
        {
            var banner = _mapper.Map<Banner>(updateBanner);
            await _bannerService.TUpdateAsync(banner);
            return RedirectToAction("Index");
        }
    }
}
