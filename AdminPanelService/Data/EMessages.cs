using AdminPanelService.Attributes;

namespace AdminPanelService.Data
{
    public enum EMessages
    {
        [StringValue("Element [{0}] was not found in DB")]
        NotFoundElement,

        [StringValue("Element [{0}] was add success in DB")]
        ElementIsAddSuccess,

        [StringValue("Element [{0}] was not add in DB")]
        ElementIsNotAdd,

        [StringValue("Element [{0}] was found in DB")]
        ElementIsFound,

        [StringValue("Element [{0}] was deleted from DB")]
        ElementIsDelete,

        [StringValue("Element [{0}] was update in DB")]
        ElementIsUpdate,

        [StringValue("Element [{0}] was not update in DB")]
        ElementIsNotUpdate,

        [StringValue("Elements [{0}] was found in DB")]
        ElementsIsFound,

        [StringValue("File: [{0}] is create")]
        FileCreated,

        [StringValue("File: [{0}] is not create")]
        FileIsNotCreated,

        [StringValue("File: [{0}] is not Found")]
        FileIsNotFound,

        [StringValue("File: [{0}] is update")]
        FileIsUpdate
    }
}
