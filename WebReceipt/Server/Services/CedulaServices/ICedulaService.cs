using Microsoft.AspNetCore.Mvc;
using WebReceipt.Models;

namespace WebReceipt.Server.Services.CedulaServices
{
    public interface ICedulaService
    {
        Task<ActionResult<CedulaModel>> AddCedula(CedulaModel receipt);
         Task<List<CedulaModel>> GetListOfCedula(FilterParameter param);
         Task<ActionResult<CedulaModel>> RemoveCedula(CedulaModel receipt);
         Task<ActionResult<CedulaModel>> UpdateCedula(CedulaModel receipt);
    }
}