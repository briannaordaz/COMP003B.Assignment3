using COMP003B.Assignment3.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment3.Controllers;

public class EventController : Controller
{
    [HttpGet("event/register/{eventCode}")]
    public IActionResult EventRegistration(string eventCode)
    {
        var model = new EventRegistration
        {
            EventCode = eventCode
        };
        return View("Register", model);
    }

    [HttpGet("event/register")]
    public IActionResult Register()
    {
        return View(new EventRegistration());
    }

    [HttpPost("event/register")]
    public IActionResult Register(EventRegistration model)
    {
        if (!ModelState.IsValid)
        {
            return View("Register", model);
        }
        
        return RedirectToAction("Success", "Event",new
        {
            
        
            model.FullName,
            model.Email,
            model.EventCode,
            model.Tickets,
            model.ReferralCode
        });
    }

    [HttpGet("event/success")]
    public IActionResult Success(string FullName, string Email, string EventCode, int Tickets, string? ReferralCode)
    {
        var model = new EventRegistration
        {
            FullName = FullName,
            Email = Email,
            EventCode = EventCode,
            Tickets = Tickets,
            ReferralCode = ReferralCode
        };
        return View(model);
    }
}