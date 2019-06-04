using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeCoreyWebApi.Models
{
    /// <summary>
    /// Represents one specific person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from sql
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// User's first name
        /// </summary>
        public string FirstName { get; set; } = "";

        /// <summary>
        /// Couldnt u guess
        /// </summary>
        public string LastName { get; set; } = "";

    }
}