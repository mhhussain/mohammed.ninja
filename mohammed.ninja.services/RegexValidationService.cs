﻿using mohammed.ninja.models;
using System.Diagnostics;
using System.Text.RegularExpressions;
using mohammed.ninja.services.Contract;

namespace mohammed.ninja.services
{
    class RegexValidationService : IRegexValidationService
    {
        public bool ValidateRegex(Puzzle[] puzzles, Answer[] answers)
        {
            Debug.Assert(answers.Length == puzzles.Length);

            for(int i = 0; i < answers.Length; ++i)
            {
                var regX = new Regex(answers[i].Regex);
                if (regX.Replace(puzzles[i].Problem, answers[i].Substitute) != puzzles[i].Goal) return false;
            }


            return true;
        }
    }
}
