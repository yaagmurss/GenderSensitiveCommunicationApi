using GenderSensitiveCommunicationApi.Data;
using GenderSensitiveCommunicationApi.ErrorHandling;
using GenderSensitiveCommunicationApi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.Xml;

namespace GenderSensitiveCommunicationApi.Controllers
{
    public class EntryController : Controller
    {
        [Route("PostEntries")]
        [HttpPost]
        public IActionResult PostEntries(EntryModel model)
        {
            var entryModel = new List<EntryModel>();

            entryModel.Add(model);

            //Forbidden words List

            var forbiddenWords = new List<string>
            {
                "bayan",
                "insanoğlu",
                "bilim adamı",
                "kadın işi",
                "erkek işi",
                "elinin hamuru"
            };

            //When the post method works, Text will be controlled to be sure it does not contain any forbidden word.        

            var flag = 0;
            
            foreach (var word in forbiddenWords)
                if (model.Text.ToLower().Contains(word))
                {
                    flag = 1;
                    break;
                }
            
            //If text contain any forbidden word than exception throws.

            if (flag == 1)
                throw new  LanguageViolationException("Violation Exception occured while reading text.");
            else
                return Ok(entryModel);


        }

    }
}
