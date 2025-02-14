using Domain.Constants;
using Domain.Entities.Accounts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Controller]
    public class BaseController : ControllerBase
    {
        public Account Account => (Account)HttpContext.Items[AccountKeyConstants.CurrentUser];
    }
}
