using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.JavaScript;

namespace COMP003B.Assignment3.Models;

public class EventRegistration
{
    [Required]
    [MinLength(3)]
    public string FullName { get; set; }
    
    [Required]
    [EmailAddress] 
    public string Email { get; set; }
    
    
    [Required]
    [MaxLength(20)]
    public string EventCode { get; set; }
    
    
    [Required]
    [Range(1, 10)]
    public string Tickets { get; set; }
    
    
    public string? ReferralCode { get; set; }
}