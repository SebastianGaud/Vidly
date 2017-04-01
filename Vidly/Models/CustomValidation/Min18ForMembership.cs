using System;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.CustomValidation
{
    public class Min18ForMembership : ValidationAttribute
    {
        protected override ValidationResult IsValid ( object value , ValidationContext validationContext )
        {
            Customer customer = validationContext.ObjectInstance as Customer;

            if ( customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1 )
            {
                return ValidationResult.Success;
            }

            if ( customer.BirthDate == null )
            {
                return new ValidationResult( "Birth date is Required" );
            }

            var age = DateTime.Now.Year - customer.BirthDate.Value.Year;

            return ( age >= 18 )
                ? ValidationResult.Success
                : new ValidationResult( "Customer should be at least 18 years old for a membership" );
        }
    }
}