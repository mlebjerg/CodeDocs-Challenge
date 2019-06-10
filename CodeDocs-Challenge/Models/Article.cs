using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CodeDocs_Challenge.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public List<string> LanguageList
        {
            get => JsonConvert.DeserializeObject<List<string>>(Language);
        }

        public string Language  { get; set; }
        public string SourceUrl { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastEdited { get; set; }
        public string ContentMD { get; set; }
        public string ContentHtml { get; set; }
    }
}
