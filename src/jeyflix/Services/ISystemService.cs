﻿using jeyflix.Services.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeyflix.Services
{
    public interface ISystemService
    {
        Task<ServerPublicInformationResponse> GetServerPublicInformationAsync();
    }
}
