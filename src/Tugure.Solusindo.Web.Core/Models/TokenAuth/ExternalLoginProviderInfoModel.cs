﻿using Abp.AutoMapper;
using Tugure.Solusindo.Web.Authentication.External;

namespace Tugure.Solusindo.Web.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
