//------------------------------------------------------------------------------
// <copyright file="WebDataService.svc.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Data.Services.Common;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;

namespace _074_DataServices
{
    public class DBService : DataService<DBEntities>
    {
        // This method is called only once to initialize service-wide policies.
        public static void InitializeService(DataServiceConfiguration config)
        {
            // TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
            // Examples:
            config.SetEntitySetAccessRule("*", EntitySetRights.All);
            config.SetServiceOperationAccessRule("GetPessoa", ServiceOperationRights.ReadSingle);

            config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V3;
        }

        [WebGet]
        [SingleResult]
        public Pessoa GetPessoa(int id)
        {
            return CurrentDataSource.PessoaSet.Find(id);
        }
    }
}

//http://localhost:8080/DBService.svc/
//...svc/PessoaSet
//...svc/PessoaSet(2)
//...svc/PessoaSet/$count
//...svc/PessoaSet?$top=3
//...svc/PessoaSet?$skip=3&$top=2
//...svc/PessoaSet?$select=Id,Nome
//...svc/PessoaSet?$orderby=Nome
//...svc/PessoaSet?$filter=Id eq 2
//...svc/PessoaSet?$filter=startswith(Nome, 'E')
//...svc/PessoaSet/GetPessoa?id=2

