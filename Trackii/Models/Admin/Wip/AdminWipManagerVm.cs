using System.ComponentModel.DataAnnotations;

namespace Trackii.Models.Admin.Wip;

public class AdminWipManagerVm
{
    [Display(Name = "WO Number")]
    public string WoNumber { get; set; } = string.Empty;

    [Display(Name = "Part Number")]
    public string PartNumber { get; set; } = string.Empty;

    public uint WorkOrderId { get; set; }
    public uint WipItemId { get; set; }
    public bool IsNewOrder { get; set; }

    public List<WipStepVm> RouteSteps { get; set; } = new();
    public List<ErrorCodeVm> ErrorCodes { get; set; } = new();
}

public class ErrorCodeVm
{
    public uint Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
}

public class WipStepVm
{
    public uint RouteStepId { get; set; }
    public uint LocationId { get; set; }
    public int StepNumber { get; set; }
    public string LocationName { get; set; } = string.Empty;

    public int QtyIn { get; set; }
    public int QtyScrap { get; set; }
    public uint? ErrorCodeId { get; set; }
    public string? ErrorCodeCategory { get; set; }
    public string? ScrapComments { get; set; }

    public bool IsCompleted { get; set; }
}
