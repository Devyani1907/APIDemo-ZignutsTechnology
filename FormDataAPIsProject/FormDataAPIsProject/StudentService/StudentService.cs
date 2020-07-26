using FormDataAPIsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormDataAPIsProject.StudentService
{
    public class StudentService
    {
        /// <summary>
        /// Evaluates all students details and return them. 
        /// </summary>
        /// <param name="details">contains student details</param>
        /// <returns>returns student information<</returns>
        public StudentsDetails GetStudentInfoInReverse(StudentsDetails details)
        {
            details.FullName = reverseString(details.FullName);
            details.EmailAddress = reverseString(details.EmailAddress);
            details.PhoneNumber = reverseString(details.PhoneNumber);
            details.Notes = reverseString(details.Notes);

            return details;
        }

        /// <summary>
        /// this method reverse the string.
        /// </summary>
        /// <param name="str">contains the string which is to be reversed</param>
        /// <returns></returns>
        private string reverseString(string str)
        {
            if (!string.IsNullOrEmpty(str))
            {
                char[] charAry = str.ToCharArray();
                string result = string.Empty;

                for (int i = str.Length - 1; i >= 0; i--)
                {
                    result = result + charAry[i];
                }
                return result;
            }
            else
            {
                return str;
            }
        }
    }
}
