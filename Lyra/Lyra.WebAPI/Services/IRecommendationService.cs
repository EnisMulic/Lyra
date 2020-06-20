using Lyra.Model.Requests;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lyra.WebAPI.Services
{
    public interface IRecommendationService<T> where T : class
    {
        Task<List<T>> Recommend(int UserID, PageRequest request);
    }
}
