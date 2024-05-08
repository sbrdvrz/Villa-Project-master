using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using Villa.Businnes.Abstrack;
using Villa.DTO.Dtos.ContactDtos;
using Villa.Entities.Concrete;

namespace Villa.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _contactService.TGetListAsync();
            var contactList = _mapper.Map<List<ResultContactDto>>(value);
            return View(contactList);
        }
        public async Task<IActionResult> DeleteContact(ObjectId id)
        {
            await _contactService.TDeleteAsync(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult CreateContact()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContact)
        {
            var newContact = _mapper.Map<Contact>(createContact);
            await _contactService.TCreateAsync(newContact);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateContact(ObjectId id)
        {
            var value = await _contactService.TGetByIdAsync(id);
            var mapUpdate = _mapper.Map<UpdateContactDto>(value);
            return View(mapUpdate);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContact)
        {
            var Contact = _mapper.Map<Contact>(updateContact);
            await _contactService.TUpdateAsync(Contact);
            return RedirectToAction("Index");
        }
    }
}
