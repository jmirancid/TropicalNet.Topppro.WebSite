﻿using System;
using System.Data.Entity;
using System.Linq;
using Topppro.Interfaces.Repositories;

namespace Topppro.Repositories.Definitions
{
    public class DownloadRepository : Repository<Topppro.Entities.Download>, IDownloadRepository
    {
        public override IQueryable<Entities.Download> All()
        {
            return Context.Download
                        .Include(a => a.Product);
        }

        public override IQueryable<Entities.Download> AllBy(
            System.Linq.Expressions.Expression<Func<Entities.Download, bool>> predicate)
        {
            return Context.Download
                        .Include(a => a.Product)
                        .Where(predicate);
        }

        public override IQueryable<Entities.Download> Filter(int skip, int take)
        {
            return Context.Download
                        .Include(a => a.Product)
                        .Skip(skip)
                        .Take(take);
        }

        public override IQueryable<Entities.Download> FilterBy(
            int skip, int take, System.Linq.Expressions.Expression<Func<Entities.Download, bool>> predicate)
        {
            return Context.Download
                        .Include(a => a.Product)
                        .Where(predicate)
                        .Skip(skip)
                        .Take(take);
        }

        public override Entities.Download Get(int id)
        {
            return Context.Download
                        .Include(a => a.Product)
                        .SingleOrDefault(a => a.DownloadId == id);
        }
    }
}