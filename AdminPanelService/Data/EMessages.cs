using AdminPanelService.Attributes;

namespace AdminPanelService.Data
{
    public enum EMessages
    {
        [StringValueAttribute("Element [{0}] was not found in DB")]
        NotFoundElement,

        [StringValueAttribute("Element [{0}] was add success in DB")]
        ElementIsAddSuccess,

        [StringValueAttribute("Element [{0}] was not add in DB")]
        ElementIsNotAdd,

        [StringValueAttribute("Element [{0}] was found in DB")]
        ElementIsFound,

        [StringValueAttribute("Element [{0}] was deleted from DB")]
        ElementIsDelete,

        [StringValueAttribute("Element [{0}] was update in DB")]
        ElementIsUpdate,

        [StringValueAttribute("Element [{0}] was not update in DB")]
        ElementIsNotUpdate,

        [StringValueAttribute("Elements [{0}] was found in DB")]
        ElementsIsFound,

        [StringValueAttribute("File: [{0}] is create")]
        FileCreated,

        [StringValueAttribute("File: [{0}] is not create")]
        FileIsNotCreated,

        [StringValueAttribute("File: [{0}] is not Found")]
        FileIsNotFound,

        [StringValueAttribute("File: [{0}] is update")]
        FileIsUpdate
    }
}
