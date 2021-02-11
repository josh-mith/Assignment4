using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class TempStorage
    {
        //Creates list of Restaurant Addition objects
        private static List<Addition> submissions = new List<Addition>();

        //Lambda continually updates submissions list
        public static IEnumerable<Addition> Submissions => submissions;

        //Adds each individual submission to submissions list
        public static void AddSubmission(Addition submission)
        {
            submissions.Add(submission);
        }
    }
}
