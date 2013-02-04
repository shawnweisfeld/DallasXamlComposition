using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DallasXAML.Composition.ViewModels
{
    public class ViewModelLocator
    {
        private FeedViewModel _feed;

        public ViewModelLocator()
        {
            _feed = new FeedViewModel
            {
                Activities = new List<ActivityViewModel>
                {
                    new RecruitingActivityViewModel { Person = "Tim R.", Candidate = "Sally S." },
                    new UserGroupActivityViewModel { Person = "Latish S.", Attendees = 40 },
                    new UserGroupActivityViewModel { Person = "Bryan S.", Attendees = 50 }
                }
            };
        }

        public FeedViewModel Feed
        {
            get { return _feed; }
        }
    }
}
