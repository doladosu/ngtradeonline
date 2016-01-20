using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;

namespace NgTradeOnline.Api.Setup.Core
{
    internal class NoOpModelBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            return true;
        }
    }
}