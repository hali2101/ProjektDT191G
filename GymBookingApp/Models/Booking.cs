using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bookingadmintest.Models
{
    public class Booking
    {
        //properties

        public int Id { get; set; }

        //sätter fältet som nödvändigt vid ifyllnad och med felmeddelande
        [Required(ErrorMessage = "Du måste ange ett namn.")]
        [Display(Name = "Namn")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Du måste ange en e-postadress.")]
        [Display(Name = "E-post")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Du måste ange ett telefonnummer.")]
        [Display(Name = "Telefonnummer")]
        [DataType(DataType.PhoneNumber)]
        public string? Phonenumber { get; set; }

        [Display(Name = "Bokningsdatum")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime? BookingDate { get; set; } = DateTime.Now;

        [Display(Name = "Träningspass")]
        [ForeignKey("Workout")]
        public int? WorkoutId { get; set; }

        [Display(Name = "Träningspass")]
        public Workout? Workout { get; set; }

    }
}