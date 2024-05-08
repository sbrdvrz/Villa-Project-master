using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Businnes.Abstrack;
using Villa.DTO.Dtos.Counter;
using Villa.Entities.Concrete;

namespace Villa.WebUI.Controllers
{
    public class CounterController : Controller
    {
        private readonly ICounterService _counterService;
        private readonly IMapper _mapper;

        public CounterController(ICounterService counterService, IMapper mapper)
        {
            _counterService = counterService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _counterService.TGetListAsync();
            var CounterList = _mapper.Map<List<ResultCounterDto>>(value);
            return View(CounterList);
        }
        public async Task<IActionResult> DeleteCounter(ObjectId id)
        {
            await _counterService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateCounter()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCounter(CreateCounterDto createCounter)
        {
            var newCounter = _mapper.Map<Counter>(createCounter);
            await _counterService.TCreateAsync(newCounter);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCounter(ObjectId id)
        {
            var value = await _counterService.TGetByIdAsync(id);
            var mapUpdate = _mapper.Map<UpdateCounterDto>(value);
            return View(mapUpdate);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCounter(UpdateCounterDto updateCounter)
        {
            var Counter = _mapper.Map<Counter>(updateCounter);
            await _counterService.TUpdateAsync(Counter);
            return RedirectToAction("Index");
        }
    }
}
