﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.CmsKit.Domain.Shared.Volo.CmsKit.Contents;

namespace Volo.CmsKit.Common.Application.Contracts.Volo.CmsKit.Contents
{
    public interface IContentRendererProvider
    {
        Task<IContentRenderer> GetContentRendererAsync(IEntityContent content);
    }
}
