using Business_Tracking.Business.Abstract;
using Business_Tracking.Entities.ORM.Concrete;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business_Tracking.UI.TagHelpers
{

    [HtmlTargetElement("JobsWithUser")]
    public class JobUserTagHelpers:TagHelper
    {
        private IJobsService _jobsService;
        public JobUserTagHelpers(IJobsService jobsService)
        {
            _jobsService = jobsService;
        }

        public int AppUserID { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            List<Jobs> jobs = _jobsService.WithUser(AppUserID);

            var endjobs = jobs.Where(i => i.status == Entities.ORM.Enum.Status.Passive).Count();
            var countjobs =jobs.Where(i => i.status == Entities.ORM.Enum.Status.Active).Count();

            string htmlString = $"<strong>Tamamaldığı görev sayısı:{endjobs}</strong> <br> <strong>Üstünde çalıştığı görev sayısı:{countjobs}</strong>";

            output.Content.SetHtmlContent(htmlString);
        }

    }
}
