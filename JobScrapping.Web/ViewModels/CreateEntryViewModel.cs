namespace JobScrapping.Web.ViewModels
{
    public class CreateEntryViewModel
    {
        public string HitId { get; set; }
        public string AssignmentId { get; set; }
        public string WorkerId { get; set; }

        public string ScrappingUrl { get; set; }

        public string JobListDeatilLinkUrl { get; set; }
        public string JobTitleXPath { get; set; }
        public string JobDescXPath { get; set; }
    }    
}