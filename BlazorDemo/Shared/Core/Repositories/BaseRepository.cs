using BlazorDemo.Shared.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Shared.Core.Repositories
{
    public class BaseRepository
    {
        public readonly DemoDbContext demoDbContext;
        public BaseRepository(DemoDbContext _demoDbContext)
        {
            demoDbContext = _demoDbContext;
        }
    }
}
