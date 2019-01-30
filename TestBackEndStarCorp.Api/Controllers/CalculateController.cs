using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TestBackEndStarCorp.Api.Models;
using TestBackEndStarCorp.Service;

namespace TestBackEndStarCorp.Api.Controllers
{
    [RoutePrefix("starcorp")]
    public class CalculateController : ApiController
    {
        private HttpResponseMessage _response;

        public CalculateController()
        {
            _response = new HttpResponseMessage();
        }

        [Route("v1/calculate")]
        public async Task<HttpResponseMessage> Post(ChallengeModelView modelView)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var challenge = new CalculateService().ChallengeCanculates(modelView.Number);
                    _response = Request.CreateResponse(HttpStatusCode.OK, challenge);
                }
            }
            catch
            {
                _response = Request.CreateResponse(HttpStatusCode.BadRequest, "Type Indefined");
            }
            var tsc = new TaskCompletionSource<HttpResponseMessage>();
            tsc.SetResult(_response);
            return await tsc.Task;
        }
    }
}
