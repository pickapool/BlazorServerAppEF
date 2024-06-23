using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.Form56Services
{
    public interface IForm456Service
    {
        Task<ActionResult<Form56Model>> AddForm56(Form56Model receipt);
         Task<List<Form56Model>> GetListOfForm56(FilterParameter param);
         Task<ActionResult<Form56Model>> RemoveForm56(Form56Model receipt);
         Task<ActionResult<Form56Model>> UpdateForm56(Form56Model receipt);
    }
}