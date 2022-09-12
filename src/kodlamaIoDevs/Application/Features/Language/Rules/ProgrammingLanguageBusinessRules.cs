using Application.Services.Repositories;
using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Language.Rules
{
    public class ProgrammingLanguageBusinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }

        public async Task ProgrammingLanguageNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<ProgrammingLanguage> result = await _programmingLanguageRepository.GetListAsync(p => p.Name == name);
            if (result.Items.Any()) throw new BusinessException($"{name} exists");
        }

        public void ProgrammingLanguageShouldExistWhenRequested(ProgrammingLanguage programmingLanguage)
        {
            if (programmingLanguage == null) throw new BusinessException("Requested Programming Language does not exist");
        }
    }
}
