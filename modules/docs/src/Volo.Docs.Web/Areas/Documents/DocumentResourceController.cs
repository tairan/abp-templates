﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Http;
using Volo.Abp.IO;
using Volo.Docs.Documents;

namespace Volo.Docs.Areas.Documents
{
    [RemoteService]
    [Area("docs")]
    [ControllerName("DocumentResource")]
    [Route("document-resources")]
    public class DocumentResourceController : AbpController
    {
        private readonly IDocumentAppService _documentAppService;

        public DocumentResourceController(IDocumentAppService documentAppService)
        {
            _documentAppService = documentAppService;
        }

        [HttpGet]
        [Route("")]
        //[Produces(MimeTypes.Image.Jpeg, MimeTypes.Image.Png, MimeTypes.Image.Gif)]
        public async Task<FileResult> GetResource(GetDocumentResourceInput input)
        {
            input.Name = input.Name.RemovePreFix("/");
            var documentResource = await _documentAppService.GetResourceAsync(input);
            var contentType = MimeTypes.GetByExtension(FileHelper.GetExtension(input.Name));
            return File(documentResource.Content, contentType);
        }
    }
}
