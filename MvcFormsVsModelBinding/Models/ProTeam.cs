using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcFormsVsModelBinding.Models
{
    /// <summary>
    /// Represents a Profesional Sports Team
    /// </summary>
    public class ProTeam
    {
        public string TeamId { get; set; }

        /// <summary>
        /// The name of the team
        /// </summary>
        [Required(ErrorMessage = "Team Name is required")]
        [Display(Name = "Enter Team Name")]
        public string NameOfTeam { get; set; }

        /// <summary>
        /// The name of the team's coach
        /// </summary>
        [Required(ErrorMessage = "Coach Name is required")]
        [Display(Name = "Enter Coach Name")]
        public string NameOfCoach { get; set; }

        /// <summary>
        /// The country that the team is from
        /// </summary>
        [Required(ErrorMessage = "Team's Country is required")]
        [Display(Name = "Enter Team's Country")]
        public string Country { get; set; }

        /// <summary>
        /// The sport that the team plays
        /// </summary>
        [Required(ErrorMessage ="Team's Sport is required")]
        [Display(Name = "Enter Team's Sport")]
        public string Sport { get; set; }

        /// <summary>
        /// When the team was founded
        /// </summary>
        [DataType(DataType.Date)]
        [Required(ErrorMessage ="Team's date of foundation is required")]
        [Display(Name = "Enter Date of Team's Foundation")]
        public DateTime DateFounded { get; set; }

    }
}
