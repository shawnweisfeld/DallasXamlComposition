using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DallasXAML.Composition.ViewModels
{
    public class UserGroupActivityViewModel : ActivityViewModel
    {
        public string Group { get; set; }
        public int Attendees { get; set; }
    }
}
