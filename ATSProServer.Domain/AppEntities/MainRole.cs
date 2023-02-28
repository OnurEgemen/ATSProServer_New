using ATSProServer.Domain.Abstractions;
using System.ComponentModel.DataAnnotations.Schema;

namespace ATSProServer.Domain.AppEntities
{
    public sealed class MainRole : Entity
    {
        public MainRole()
        {

        }
        public MainRole(string id, string title, bool isRoleCreatedByAdmin = false, 
            string firmId = null) : base(id)
        {
            Title = title;
            IsRoleCreatedByAdmin = isRoleCreatedByAdmin;
            FirmId = firmId;
        }

        public string Title { get; set; }
        public bool IsRoleCreatedByAdmin { get; set; }

        [ForeignKey("Firm")]
        public string FirmId { get; set; }
        public Firm? Firm { get; set; }

    }
}

//01.01.16