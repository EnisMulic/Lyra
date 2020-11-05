using AutoMapper;
using Lyra.Model.Requests;
using Lyra.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public class RSIICovidExamServic :
        CRUDService<Model.RSIICovidExam, RSIICovidExamSearchRequest, Database.RSIICovidExam, RSIICovidExamUpsertRequest, RSIICovidExamUpsertRequest>
    {
        private readonly LyraContext _context;
        private readonly IMapper _mapper;
        public RSIICovidExamServic(LyraContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override async Task<List<Model.RSIICovidExam>> Get(RSIICovidExamSearchRequest search)
        {
            var query = _context.RSIICovidExams
                .Include(i => i.User)
                .AsQueryable();

            query = ApplyFilter(query, search);

            var list = await query.ToListAsync();

            return _mapper.Map<List<Model.RSIICovidExam>>(list);
        }

        private IQueryable<RSIICovidExam> ApplyFilter(IQueryable<RSIICovidExam> query, RSIICovidExamSearchRequest search)
        {
            if(!string.IsNullOrEmpty(search.Username))
            {
                var list = search.Username.Split(" ");
                query = query.Where(i => list.Contains(i.User.FirstName) || list.Contains(i.User.LastName));
            }

            if(search.From != null)
            {
                query = query.Where(i => i.DateTested.Date.CompareTo(Convert.ToDateTime(search.From).Date) >= 0);
            }

            if (search.To != null)
            {
                query = query.Where(i => i.DateTested.Date.CompareTo(Convert.ToDateTime(search.To).Date) <= 0);
            }

            if(search.TestPositive != null)
            {
                query = query.Where(i => i.TestPositive == search.TestPositive);
            }

            return query;
        }
    }
}
