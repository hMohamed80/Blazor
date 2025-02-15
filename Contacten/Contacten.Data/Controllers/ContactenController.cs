using Contacten.Data.Models;
using Contacten.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contacten.Data.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContactenController : ControllerBase
{
    private readonly IContactenRepository contactenRepository;
    public ContactenController(IContactenRepository contactenRepository)
    {
        this.contactenRepository = contactenRepository;
    }
    [HttpGet]
    public async Task<ActionResult> GetContacten()
    {
        try
        {
            return Ok(await contactenRepository.GetContacten());
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
            "Database error");
        }
    }
    [HttpGet("{id:int}")]
    public async Task<ActionResult<Contact>> GetContact(int id)
    {
        try
        {
            var result = await contactenRepository.GetContact(id);
            if (result == null) return NotFound();
            return result;
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
            "Database error");
        }
    }
    [HttpPost]
    public async Task<ActionResult<Contact>> CreateContact(Contact contact)
    {
        try
        {
            var createdContact = await contactenRepository.AddContact(contact);
            return CreatedAtAction(nameof(CreateContact),
                new { id = createdContact.ContactId }, createdContact);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
            "Database error");
        }
    }
    [HttpPut("{id:int}")]
    public async Task<ActionResult<Contact>> UpdateContact(int id, Contact contact)
    {
        try
        {
            var contactToUpdate = await contactenRepository.GetContact(id);
            if (contactToUpdate == null)
                return NotFound($"Contact with id = {id} is not found");
            return await contactenRepository.UpdateContact(contact);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
            "Error updating data");
        }
    }
    [HttpDelete("{id:int}")]
    public async Task<ActionResult<Contact>> DeleteContact(int id)
    {
        try
        {
            var contactToDelete = await contactenRepository.GetContact(id);
            if (contactToDelete == null)
                return NotFound($"Contact with id = {id} is not found");
            return await contactenRepository.DeleteContact(id);
        }
        catch (Exception)
        {
            return StatusCode(StatusCodes.Status500InternalServerError,
            "Error deleting data");
        }
    }
}
