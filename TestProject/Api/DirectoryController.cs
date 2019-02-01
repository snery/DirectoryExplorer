using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using TestProject.Data.Service;

namespace TestProject.Api
{
    [AllowAnonymous]
    [RoutePrefix("api/directory")]
    public class DirectoryController : ApiController
    {
        private DirectoryExplorer DirExplorer { get; set; }

        public DirectoryController()
        {
            DirExplorer = new DirectoryExplorer();
        }

        [HttpGet]
        [Route("")]
        public HttpResponseMessage GetDirectoryContents([FromUri] string directory)
        {  
            try
            {
                var content = DirExplorer.GetFolderContents(directory);
                return Request.CreateResponse(content);
            } catch (Exception ex)
            {
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
        }

    }
}