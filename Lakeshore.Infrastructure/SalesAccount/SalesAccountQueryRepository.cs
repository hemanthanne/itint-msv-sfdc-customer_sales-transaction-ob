﻿using Lakeshore.Domain.SalesAccountRepository;
using Lakeshore.Infrastructure.EntityModelConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lakeshore.Infrastructure.SalesAccount
{
    public class SalesAccountQueryRepository : ISalesAccountQueryRepository
    {
        private readonly SalesAccountContext _context;

        public SalesAccountQueryRepository(SalesAccountContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task<List<Domain.Models.SalesAccount>> GetSalesAccount(CancellationToken cancellationToken)
        {
            return await _context.SalesAccount.ToListAsync(cancellationToken);
        }
    }
}
